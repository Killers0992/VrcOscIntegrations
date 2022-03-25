using VrcOscIntegrations.Models;

namespace VrcOscIntegrations
{
    public class MainConfig
    {
        public static MainConfig Instance = new MainConfig();

        public static void Load()
        {
            if (!File.Exists("./config.yml"))
            {
                Logger.Debug("Config", "Create missing \"MainConfig\".", Color.Azure, Color.White);
                File.WriteAllText("./config.yml", YDS.Serializer.Serialize(new MainConfig()));
            }

            Logger.Debug("Config", "Load \"MainConfig\".", Color.Azure, Color.White);
            Instance = YDS.Deserializer.Deserialize<MainConfig>(File.ReadAllText("./config.yml"));
            Save();
        }

        public static void Save()
        {
            if (Instance == null) return;
            File.WriteAllText("./config.yml", YDS.Serializer.Serialize(Instance));
            Logger.Debug("Config", "Saved \"MainConfig\".", Color.Azure, Color.White);
        }

        [YamlMember(Description = "More information in console for debugging purpose.")]
        public bool Debug { get; set; }

        [YamlMember(Description = "Auto updates for installed integrations.")]
        public bool AutoUpdater { get; set; } = true;

        [YamlMember(Description = "Information needed for connecting with OSC running in VRC.")]
        public OscServer OscServer { get; set; } = new OscServer();

        [YamlMember(Description = "Web server running on localhost.")]
        public WebServer WebServer { get; set; } = new WebServer();
    }
}
