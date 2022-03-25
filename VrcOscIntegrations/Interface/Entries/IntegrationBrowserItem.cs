namespace VrcOscIntegrations.Interface.Entries
{
    public partial class IntegrationBrowserItem : PoisonUserControl
    {
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

        }
    }
}
