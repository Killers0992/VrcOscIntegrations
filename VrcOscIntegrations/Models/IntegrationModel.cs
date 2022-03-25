using Newtonsoft.Json;

namespace VrcOscIntegrations.Models
{
    public class IntegrationModel
    {
        public string Id { get; set; }
        [JsonIgnore]
        public int BrowserViewID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Image { get; set; }
        public string GithubRepo { get; set; }
        public string VersionFile { get; set; }

        IVrcIntegration<IConfig> _base;
        [JsonIgnore]
        public IVrcIntegration<IConfig> Base
        {
            get
            {
                if (_base == null)
                    _base = IntegrationsManager.Integrations.ContainsKey(Id) ? IntegrationsManager.Integrations[Id] : null;

                return _base;
            }
        }
    }
}
