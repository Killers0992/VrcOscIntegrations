using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace VrcOscIntegrations.Interface
{
    public partial class MainPanel : PoisonForm
    {
        public static event EventHandler<ConsoleLogArgs> LogReceived;

        public static List<ConsoleLogArgs> PendingLogs = new List<ConsoleLogArgs>();

        public static List<IntegrationModel> BrowserIntegrationItems = new List<IntegrationModel>();

        public static MainPanel singleton;

        public static bool IsLoaded;

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
            debugSwitch.Switched = MainConfig.Instance.Debug;
            foreach(var e in PendingLogs.ToArray())
                AddConsoleLog(e.Time, e.Type, e.TagColor, e.TagMessage, e.MessageColor, e.Message);
            PendingLogs.Clear();

            debugSwitch.SwitchedChanged += OnDebugChanged;

            foreach(var item in IntegrationsManager.Integrations)
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

            RefreshIntegrationsBrowser();
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

        void OnDebugChanged(object sender)
        {
            MainConfig.Instance.Debug = debugSwitch.Switched;
            MainConfig.Save();
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
    }
}