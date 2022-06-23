using Microsoft.Toolkit.Uwp.Notifications;
using Newtonsoft.Json;
using System.Text;
using VrcOscIntegrations.Properties;

namespace VrcOscIntegrations.Services
{
    public class AutoUpdater : BackgroundService
    {
        public static Dictionary<string, PendingUpdate> PendingUpdates = new Dictionary<string, PendingUpdate>();

        public static List<PendingUpdate> ReadyUpdate = null;
        public static bool IsUpdating;

        HttpClient _client = new HttpClient();

        string _panelVersionUrl => "https://raw.githubusercontent.com/Killers0992/VrcOscIntegrations/master/version.json";

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (File.Exists("./old_VrcOscIntegrations.exe"))
                File.Delete("./old_VrcOscIntegrations.exe");

            while (true)
            {
                var panelUpdate = await CheckUpdate("Panel", MainPanel.CurrentVersion.Version, _panelVersionUrl);

                if (panelUpdate != null && !PendingUpdates.ContainsKey("panel") && ReadyUpdate == null)
                {
                    PendingUpdates.Add("panel", new PendingUpdate()
                    {
                        Id = "panel",
                        DisplayName = "VRC OSC Integrations Panel",
                        Changelogs = panelUpdate.ChangeLogs,
                        CurrentVersion = MainPanel.CurrentVersion.Version,
                        NewVersion = panelUpdate.Version,
                    });
                }

                await Task.Delay(5000);
            }
        }

        public async Task<IntegrationVersionInfo> CheckUpdate(string name, string currentVersion, string url)
        {
            var result = await _client.GetAsync(url);
            if (!result.IsSuccessStatusCode)
            {
                Logger.Info("AutoUpdater", $"Failed getting version of {name}.", Color.White, Color.White);
                return null;
            }

            var content = await result.Content.ReadAsStringAsync();
            var ver = JsonConvert.DeserializeObject<IntegrationVersionInfo>(content);

            if (!Version.TryParse(ver.Version, out Version latestVersion))
            {
                Logger.Info("AutoUpdater", $"Failed parsing latest version from {name} ( {ver.Version} ).", Color.White, Color.White);
                return null;
            }


            if (!Version.TryParse(currentVersion, out Version version))
            {
                Logger.Info("AutoUpdater", $"Failed parsing version from {name} ( {ver.Version} ).", Color.White, Color.White);
                return null;
            }

            if (version.CompareTo(latestVersion) < 0)
                return ver;
            else
                return null;
        }
    }
}
