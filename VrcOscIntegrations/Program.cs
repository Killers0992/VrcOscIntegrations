using Newtonsoft.Json;

namespace VrcOscIntegrations
{
    internal static class Program
    {
        static MainPanel _panel;

        [STAThread]
        static void Main(string[] args)
        {
            var window = ConsoleWindow.GetConsoleWindow();
            ConsoleWindow.ShowWindow(window, 0);

            if (!Directory.Exists("Integrations"))
                Directory.CreateDirectory("Integrations");

            if (!Directory.Exists("Dependencies"))
                Directory.CreateDirectory("Dependencies");

            ApplicationConfiguration.Initialize();

            MainConfig.Load();
            IntegrationsManager.Manager.LoadIntegrations();

            CancellationTokenSource cts = new CancellationTokenSource();

            WebHost.CreateDefaultBuilder(args)
                //.ConfigureLogging(p => p.SetMinimumLevel(LogLevel.Error))
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