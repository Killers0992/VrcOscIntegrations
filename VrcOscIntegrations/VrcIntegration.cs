
using CoreOSC;

namespace VrcOscIntegrations
{
    public abstract class VrcIntegration<TConfig> : IVrcIntegration<TConfig>
        where TConfig : IConfig, new()
    {
        string _integrationId;
        public string Id
        {
            get
            {
                if (_integrationId == null)
                    _integrationId = $"{Author}.{Name}".ToLower().Replace(" ", "-");

                return _integrationId;
            }
        }

        public virtual string Name { get; }

        public virtual string Author { get; }

        public virtual Version Version { get; }

        public IntegrationStatus Status { get; set; } = IntegrationStatus.NotLoaded;
        public string IntegrationPath { get; set; }
        public virtual PoisonUserControl MainPanel { get; }

        public virtual void OnEnable() => Logger.Info(Id, "Enabled integration.", Color.Cyan, Color.White);

        public virtual void OnRegister(ref IServiceCollection services) => Logger.Info(Id, "Registered integration.", Color.Cyan, Color.White);

        public virtual IConfig OnCreateDefaultConfig()
        {
            return Config;
        }

        public virtual void OnReceiveOscMessage(string address, OscMessage message)
        {
        }

        public void SaveConfig() => File.WriteAllText(Path.Combine(IntegrationPath, "config.yml"), YDS.Serializer.Serialize(Config));
        public TConfig Config { get; } = new TConfig();
    }
}
