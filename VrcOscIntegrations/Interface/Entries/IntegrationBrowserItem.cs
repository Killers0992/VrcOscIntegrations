using Newtonsoft.Json;
using System.IO.Compression;
using VrcOscIntegrations.Services;

namespace VrcOscIntegrations.Interface.Entries
{
    public partial class IntegrationBrowserItem : PoisonUserControl
    {
        HttpClient _client = new HttpClient();

        public IntegrationBrowserItem()
        {
            InitializeComponent();
        }

        public string Id { get; set; }

        string _image;
        public string Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                integrationImage.ImageLocation = _image;
            }
        }

        string _name;
        public string IntegrationName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                integrationName.Text = _name;
            }
        }

        string _desc;
        public string Description
        {
            get
            {
                return _desc;
            }
            set
            {
                _desc = value;
                integrationDescription.Text = _desc;
            }
        }

        string _author;
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
                integrationAuthor.Text = _author;
            }
        }

        string _installedVersion;
        public string InstalledVersion
        {
            get
            {
                return _installedVersion;
            }
            set
            {
                _installedVersion = value;
            }
        }

        bool _isInstalled;
        public bool IsInstalled
        {
            get
            {
                return _isInstalled;
            }
            set
            {
                _isInstalled = value;
                if (_isInstalled)
                {
                    interactionButton.Text = $"Installed\n{InstalledVersion}";
                    interactionButton.Enabled = false;
                }
                else
                {
                    interactionButton.Text = "Install";
                    interactionButton.Enabled = true;
                }
            }
        }

        public void UpdateStatus()
        {
            if (IntegrationsManager.Integrations.TryGetValue(Id, out IVrcIntegration<IConfig> inter))
            {
                InstalledVersion = inter.Version.ToString(3);
                IsInstalled = true;
            }
            else
                IsInstalled = false;
        }

        private void interactionButton_Click(object sender, EventArgs e)
        {
            var browserItem = MainPanel.BrowserIntegrationItems.FirstOrDefault(p => p.Id == Id);


            if (browserItem == null) return;

            var result = _client.GetAsync(browserItem.VersionFile).Result;
            if (!result.IsSuccessStatusCode)
            {
                Logger.Error("Browser", $"Failed getting verion file for integration {IntegrationName}! ( network failure )", Color.White, Color.White);
                return;
            }
            var content = result.Content.ReadAsStringAsync().Result;

            var versionObject = JsonConvert.DeserializeObject<IntegrationVersionInfo>(content);

            if (versionObject == null)
            {
                Logger.Error("Browser", $"Failed deserializing version file {IntegrationName}!", Color.White, Color.White);
                return;
            }

            AutoUpdater.ReadyUpdate = new List<PendingUpdate>()
            {
                new PendingUpdate()
                {
                    Id = Id,
                    NewVersion = versionObject.Version,
                    DisplayName = IntegrationName,
                    GithubRepo = browserItem.GithubRepo,
                    IntegrationFileName = versionObject.IntegrationFileName,
                    DependenciesFileName = versionObject.DependenciesFileName,
                    IsUpdate = false,
                    Type = UpdateType.Integration,
                }
            };
        }
    }
}
