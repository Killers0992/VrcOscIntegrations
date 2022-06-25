using VrcOscIntegrations.Models;

namespace VrcOscIntegrations
{
    public class MainConfig
    {
        public static MainConfig Instance = new MainConfig();

        public static void Load()
        {
            if (!File.Exists(Program.ConfigPath))
            {
                Logger.Debug("Config", "Create missing \"MainConfig\".", Color.Azure, Color.White);
                File.WriteAllText(Program.ConfigPath, YDS.Serializer.Serialize(new MainConfig()));
            }

            Logger.Debug("Config", "Load \"MainConfig\".", Color.Azure, Color.White);
            Instance = YDS.Deserializer.Deserialize<MainConfig>(File.ReadAllText(Program.ConfigPath));
            Save();
        }

        public static void Save()
        {
            if (Instance == null) return;
            File.WriteAllText(Program.ConfigPath, YDS.Serializer.Serialize(Instance));
            Logger.Debug("Config", "Saved \"MainConfig\".", Color.Azure, Color.White);
        }

        [YamlMember(Description = "More information in console for debugging purpose.")]
        public bool Debug { get; set; }

        [YamlMember(Description = "Auto updates for installed integrations.")]
        public bool AutoUpdater { get; set; } = true;

        [YamlMember(Description = "Information needed for connecting with OSC running in VRC.")]
        public OscServer OscClient { get; set; } = new OscServer();
        [YamlMember(Description = "Information needed for VRChat connecting to OSC server.")]
        public OscServer OscServer { get; set; } = new OscServer() { Port = 9001 };

        [YamlMember(Description = "Web server running on localhost.")]
        public WebServer WebServer { get; set; } = new WebServer();
    }
}
