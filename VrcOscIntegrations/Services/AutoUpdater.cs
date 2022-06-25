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
            while (true)
            {
                if (!MainConfig.Instance.AutoUpdater)
                {
                    await Task.Delay(5000);
                    continue;
                }

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

                foreach(var integration in IntegrationsManager.Integrations)
                {
                    if (PendingUpdates.ContainsKey(integration.Value.Id)) continue;

                    var webIntegration = MainPanel.BrowserIntegrationItems.FirstOrDefault(x => x.Id == integration.Value.Id);
                    if (webIntegration == null)
                    {
                        Logger.Warn("AutoUpdater", $"Integration with id \"{integration.Value.Id}\" is not added to integrations.json on VRC Osc Integrations repository.", Color.White, Color.White);
                        continue;
                    }

                    var integrationResult = await CheckUpdate(integration.Value.Name, integration.Value.Version.ToString(), webIntegration.VersionFile);
                    if (integrationResult == null) continue;


                    PendingUpdates.Add(integration.Value.Id, new PendingUpdate()
                    {
                        Id = integration.Value.Id,
                        GithubRepo = webIntegration.GithubRepo,
                        IntegrationFileName = integrationResult.IntegrationFileName,
                        DependenciesFileName = integrationResult.DependenciesFileName,
                        Type = UpdateType.Integration,
                        DisplayName = integration.Value.Name,
                        Changelogs = integrationResult.ChangeLogs,
                        CurrentVersion = integration.Value.Version.ToString(),
                        NewVersion = integrationResult.Version,
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
