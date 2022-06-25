using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Forms;
using System;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Windows.Forms;
using VrcOscIntegrations.Properties;
using VrcOscIntegrations.Services;

namespace VrcOscIntegrations.Interface
{
    public partial class MainPanel : PoisonForm
    {
        public static event EventHandler<ConsoleLogArgs> LogReceived;

        public static List<ConsoleLogArgs> PendingLogs = new List<ConsoleLogArgs>();

        public static List<IntegrationModel> BrowserIntegrationItems = new List<IntegrationModel>();

        public static MainPanel singleton;

        public static bool IsLoaded;
        public static PanelVersion CurrentVersion = new PanelVersion()
        {
            Version = "1.0.4"
        };

        private PoisonTaskWindow _updatesWindow;

        public static void OnReceiveLog(ConsoleLogArgs e)
        {
            if (LogReceived != null && IsLoaded)
                LogReceived(null, e);
            else
                PendingLogs.Add(e);
        }

        public MainPanel()
        {
            singleton = this;
            InitializeComponent();

            LogReceived += new EventHandler<ConsoleLogArgs>(OnReceiveConsoleLog);
            
            foreach(var e in PendingLogs.ToArray())
                AddConsoleLog(e.Time, e.Type, e.TagColor, e.TagMessage, e.MessageColor, e.Message);
            
            PendingLogs.Clear();

            //
            debugSwitch.Switched = MainConfig.Instance.Debug;
            debugSwitch.SwitchedChanged += (o) =>
            {
                MainConfig.Instance.Debug = debugSwitch.Switched;
                MainConfig.Save();
            };

            autoUpdater.Switched = MainConfig.Instance.AutoUpdater;
            autoUpdater.SwitchedChanged += (o) =>
            {
                MainConfig.Instance.AutoUpdater = autoUpdater.Switched;
                MainConfig.Save();
            };

            clientIp.Text = MainConfig.Instance.OscClient.IpAddress;
            clientIp.TextChanged += (o, e) =>
            {
                MainConfig.Instance.OscClient.IpAddress = clientIp.Text;
                MainConfig.Save();
            };

            clientPort.Value = MainConfig.Instance.OscClient.Port;
            clientPort.ValueChanged += (o, e) =>
            {
                MainConfig.Instance.OscClient.Port = (int)clientPort.Value;
                MainConfig.Save();
            };

            serverIp.Text = MainConfig.Instance.OscServer.IpAddress;
            serverIp.TextChanged += (o, e) =>
            {
                MainConfig.Instance.OscServer.IpAddress = serverIp.Text;
                MainConfig.Save();
            };

            serverPort.Value = MainConfig.Instance.OscServer.Port;
            serverPort.ValueChanged += (o, e) =>
            {
                MainConfig.Instance.OscServer.Port = (int)serverPort.Value;
                MainConfig.Save();
            };

            webServer.Text = MainConfig.Instance.WebServer.Url;
            webServer.TextChanged += (o, e) =>
            {
                MainConfig.Instance.WebServer.Url = webServer.Text;
                MainConfig.Save();
            };

            //
            foreach (var item in IntegrationsManager.Integrations)
            {
                var inter = new IntegrationItem()
                {
                    Id = item.Key,
                    IntegrationName = item.Value.Name,
                    Author = item.Value.Author,
                    Width = myIntegrationsTab.Width - 25,
                };
                myIntegrations.Controls.Add(inter);
            }

            integrationsBrowserSearch.Text = string.Empty;
            versionLabel.Text = CurrentVersion.Version;
            RefreshIntegrationsBrowser();

            checkPendingUpdates.Tick += (o, e) =>
            {
                if (AutoUpdater.ReadyUpdate != null && !AutoUpdater.IsUpdating)
                {
                    AutoUpdater.IsUpdating = true;
                    progressBar.Visible = true;
                    progressText.Visible = true;
                    fileDownloader.RunWorkerAsync();
                    return;
                }


                if (AutoUpdater.PendingUpdates.Count == 0) return;

                if (_updatesWindow != null) return;

                _updatesWindow = new PoisonTaskWindow(0, new UpdateNotify(AutoUpdater.PendingUpdates.Values.ToList()))
                {
                    Text = "Found new updates...",
                    Resizable = false,
                    MinimizeBox = false,
                    MaximizeBox = false,
                    Movable = true,
                    WindowState = FormWindowState.Normal,
                };
                _updatesWindow.Controls[0].Parent = _updatesWindow;

                _updatesWindow.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
                _updatesWindow.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
                _updatesWindow.Show();
                _updatesWindow.Size = new System.Drawing.Size(345, 460);
                AutoUpdater.PendingUpdates.Clear();
            };
        }

        public void RefreshIntegrationsBrowser()
        {
            var avaliableAddons = BrowserIntegrationItems
                .Select(p => p.Id);

            var integrationsInBrowser = integrationsBrowser.Controls
                .Cast<IntegrationBrowserItem>()
                .Select(p => p.Id);

            //Remove not existing integrations from browser.
            foreach(var removeIntegration in integrationsBrowser.Controls
                .Cast<IntegrationBrowserItem>()
                .Where(p => !avaliableAddons.Contains(p.Id)))
            {
                integrationsBrowser.Controls.Remove(removeIntegration);
            }

            //Add missing integrations into browser.
            foreach(var addIntegration in BrowserIntegrationItems
                .Where(p => !integrationsInBrowser.Contains(p.Id)))
            {
                addIntegration.BrowserViewID = integrationsBrowser.Controls.Count;

                var integrationItem = new IntegrationBrowserItem()
                {
                    Id = addIntegration.Id,
                    Image = addIntegration.Image,
                    IntegrationName = addIntegration.Name,
                    Description = addIntegration.Description,
                    Author = addIntegration.Author,
                    Width = integrationsBrowser.Width - 25,
                };

                integrationItem.UpdateStatus();
                integrationsBrowser.Controls.Add(integrationItem);
            }


            //Apply filters
            if (string.IsNullOrEmpty(integrationsBrowserSearch.Text))
            {
                foreach (IntegrationBrowserItem control in integrationsBrowser.Controls)
                    control.Visible = true;
            }
            else
            {
                foreach (IntegrationBrowserItem control in integrationsBrowser.Controls)
                    if (control.IntegrationName.ToLower().Replace(" ", "") == integrationsBrowserSearch.Text.ToLower().Replace(" ", "") ||
    control.IntegrationName.ToLower().Replace(" ", "").Contains(integrationsBrowserSearch.Text.ToLower().Replace(" ", "")))
                        control.Visible = true;
                    else
                        control.Visible = false;
            }
        }

        void OnReceiveConsoleLog(object sender, ConsoleLogArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    OnReceiveConsoleLog(sender, e);
                });
                return;
            }
            AddConsoleLog(e.Time, e.Type, e.TagColor, e.TagMessage, e.MessageColor, e.Message);
        }


        public void AddConsoleLog(DateTime time, LogType type, Color tagColor, string tagMessage, Color messageColor, string message)
        {
            List<string> lines = message.SplitToLines(100).ToList();

            var control = new ConsoleLogEntry()
            {
                TimeStamp = time,
                LogType = type,
                TagColor = tagColor,
                TagMessage = tagMessage,
                MessageColor = messageColor,
                Message = lines[0],
                Width = consoleLogs.Width - 25
            };
            consoleLogs.Controls.Add(control);

            if (lines.Count == 1)
            {
                consoleLogs.ScrollControlIntoView(control);
                return;
            }
            ConsoleLogExtendEntry last = null;
            for (int x = 1; x < lines.Count; x++)
            {
                var emptyControl = new ConsoleLogExtendEntry()
                {
                    MessageColor = messageColor,
                    Message = lines[x],
                    Width = consoleLogs.Width - 25
                };

                last = emptyControl;
                consoleLogs.Controls.Add(emptyControl);
            }
            consoleLogs.ScrollControlIntoView(last);
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            RefreshIntegrationsBrowser();
        }

        private void integrationsBrowserSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshIntegrationsBrowser();
        }

        private void main_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshIntegrationsBrowser();
        }

        private void settingsTab_Click(object sender, EventArgs e)
        {

        }

        private void poisonLabel9_Click(object sender, EventArgs e)
        {

        }

        private void fileDownloader_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            progressBar.Visible = false;
            progressText.Visible = false;

            string currentPath = Path.Combine(AppContext.BaseDirectory, $"VrcOscIntegrations.exe");
            ProcessStartInfo startInfo = new ProcessStartInfo(currentPath);
            Process.Start(startInfo);
            Process.GetCurrentProcess().Kill();
        }

        private void fileDownloader_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int updatesCount = AutoUpdater.ReadyUpdate.Count;

            for (int x = 0; x < updatesCount; x++)
            {
                string tempPath =
                    AutoUpdater.ReadyUpdate[x].Type == UpdateType.Panel ? 
                    Path.Combine(Program.TempPath, $"temp_VrcOscIntegrations.exe") :
                    Path.Combine(Program.TempPath, $"temp_{AutoUpdater.ReadyUpdate[x].IntegrationFileName}.dll");

                switch (AutoUpdater.ReadyUpdate[x].Type)
                {
                    case UpdateType.Panel:
                        DownloadFileWithProgress($"https://github.com/Killers0992/VrcOscIntegrations/releases/download/{AutoUpdater.ReadyUpdate[x].NewVersion}/VrcOscIntegrations.exe", AutoUpdater.ReadyUpdate[x].DisplayName, x + 1, updatesCount, tempPath, "VrcOscIntegrations.exe", progressBar, progressText);
                        break;
                    case UpdateType.Integration:
                        DownloadFileWithProgress($"{AutoUpdater.ReadyUpdate[x].GithubRepo}/releases/download/{AutoUpdater.ReadyUpdate[x].NewVersion}/{AutoUpdater.ReadyUpdate[x].IntegrationFileName}.dll", AutoUpdater.ReadyUpdate[x].DisplayName, x + 1, updatesCount, tempPath, $"{AutoUpdater.ReadyUpdate[x].IntegrationFileName}.dll", progressBar, progressText);

                        if (!string.IsNullOrEmpty(AutoUpdater.ReadyUpdate[x].DependenciesFileName))
                        {
                            var depFile = $"{AutoUpdater.ReadyUpdate[x].GithubRepo}/releases/download/{AutoUpdater.ReadyUpdate[x].NewVersion}/{AutoUpdater.ReadyUpdate[x].DependenciesFileName}.zip";
                            var depTargetFile = Path.Combine(Program.TempPath, $"{AutoUpdater.ReadyUpdate[x].DependenciesFileName}.zip");

                            DownloadFileWithProgress(depFile, AutoUpdater.ReadyUpdate[x].DisplayName + " deps", x + 1, updatesCount, depTargetFile, $"{AutoUpdater.ReadyUpdate[x].DependenciesFileName}.zip", progressBar, progressText, false);

                            Logger.Info("AutoUpdater", $"Extract all dependencies for {AutoUpdater.ReadyUpdate[x].DisplayName} into dependencies folder...", Color.White, Color.White);

                            using (ZipArchive archive = ZipFile.OpenRead(depTargetFile))
                            {
                                foreach (ZipArchiveEntry entry in archive.Entries.Where(p => p.Name.EndsWith(".dll")))
                                {
                                    var depTargetFile2 = Path.Combine(Program.DependenciesPath, $"{entry.Name}.dll");

                                    if (!File.Exists(depTargetFile2))
                                        entry.ExtractToFile(depTargetFile2);
                                }
                            }
                            Logger.Info("AutoUpdater", $"Extracted all dependencies for {AutoUpdater.ReadyUpdate[x].DisplayName} into dependencies folder!", Color.White, Color.White);
                        }
                        break;
                }
            }
        }

        void DownloadFileWithProgress(string url, string displayName, int current, int max, string path, string fileName, PoisonProgressBar progress, PoisonLabel progressText, bool archive = true)
        {
            int bytesProcess = 0;
            Stream remoteStream = null;
            Stream localStream = null;
            WebResponse response = null;

            try
            {
                WebRequest request = WebRequest.Create(url);
                if (request != null)
                {
                    double TotalBytesToReceive = 0;
                    var SizewebRequest = HttpWebRequest.Create(new Uri(url));
                    SizewebRequest.Method = "HEAD";

                    using(var webResponse = SizewebRequest.GetResponse())
                    {
                        var fileSize = webResponse.Headers.Get("Content-Length");
                        TotalBytesToReceive = Convert.ToDouble(fileSize);
                    }

                    response = request.GetResponse();
                    if (response != null)
                    {
                        remoteStream = response.GetResponseStream();

                        localStream = File.Create(path);

                        byte[] buffer = new byte[1024];
                        int bytesRead = 0;

                        do
                        {
                            bytesRead = remoteStream.Read(buffer, 0, buffer.Length);

                            localStream.Write(buffer, 0, bytesRead);

                            bytesProcess += bytesRead;

                            double bytesIn = (double)bytesProcess;
                            double percentage = bytesIn / TotalBytesToReceive * 100;
                            percentage = Math.Round(percentage, 0);

                            if (progress.InvokeRequired)
                            {
                                progress.Invoke(new Action(() =>
                                {
                                    progress.Value = (int)Math.Truncate(percentage);
                                }));
                            }
                            else
                            {
                                progress.Value = (int)Math.Truncate(percentage);
                            }


                            if (progressText.InvokeRequired)
                            {
                                progressText.Invoke(new Action(() =>
                                {
                                    progressText.Text = $"Downloading update for {displayName}... ( {current}/{max} )";
                                }));
                            }
                            else
                            {
                                progressText.Text = $"Downloading update for {displayName}... ( {current}/{max} )";
                            }
                        } while (bytesRead > 0);
                    }

                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                if (response != null) response.Close();
                if (remoteStream != null) remoteStream.Close();
                if (localStream != null) localStream.Close();

                string currentPath = Path.Combine(Path.GetDirectoryName(path), fileName);

                string archivePath = Path.Combine(Program.TempPath, $"old_{fileName}");

                if (archive && File.Exists(currentPath)) File.Move(currentPath, archivePath, true);
                File.Move(path, currentPath, true);
            }
        }
    }
}