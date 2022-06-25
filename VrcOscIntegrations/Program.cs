using Newtonsoft.Json;

namespace VrcOscIntegrations
{
    internal static class Program
    {
        static MainPanel _panel;

        public static string MainPath;
        public static string TempPath;
        public static string IntegrationsPath;
        public static string DependenciesPath;
        public static string ConfigPath;

        [STAThread]
        static void Main(string[] args)
        {
            var window = ConsoleWindow.GetConsoleWindow();
            ConsoleWindow.ShowWindow(window, 0);

            MainPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "VrcOscIntegrations");
            TempPath = Path.Combine(MainPath, "_temp");
            IntegrationsPath = Path.Combine(MainPath, "Integrations");
            DependenciesPath = Path.Combine(MainPath, "Dependencies");
            ConfigPath =  Path.Combine(MainPath, "config.yml");

            if (File.Exists("./old_VrcOscIntegrations.exe"))
                File.Delete("./old_VrcOscIntegrations.exe");

            if (!Directory.Exists(MainPath))
                Directory.CreateDirectory(MainPath);

            if (!Directory.Exists(IntegrationsPath))
                Directory.CreateDirectory(IntegrationsPath);

            if (!Directory.Exists(DependenciesPath))
                Directory.CreateDirectory(DependenciesPath);

            if (!Directory.Exists(TempPath))
                Directory.CreateDirectory(TempPath);
            else
            {
                foreach (var file in Directory.GetFiles(TempPath))
                {
                    File.Delete(file);
                }
            }

            ApplicationConfiguration.Initialize();

            MainConfig.Load();
            IntegrationsManager.Manager.LoadIntegrations();

            CancellationTokenSource cts = new CancellationTokenSource();

            WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging(p => p.SetMinimumLevel(LogLevel.Error))
                .UseUrls(MainConfig.Instance.WebServer.Url)
                .UseStartup<Startup>()
                .Build()
                .RunAsync(cts.Token);

            _panel = new MainPanel();
            Application.Run(_panel);

            cts.Cancel();
        }
    }
}