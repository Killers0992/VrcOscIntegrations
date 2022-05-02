using Newtonsoft.Json;

namespace VrcOscIntegrations.Services
{
    public class IntegrationsFetch : BackgroundService
    {
        HttpClient _client = new HttpClient();

        string _url => "https://raw.githubusercontent.com/Killers0992/VrcOscIntegrations/master/integrations.json";

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                Logger.Info("Browser", "Fetch avaliable integrations...", Color.White, Color.White);
                var result = await _client.GetAsync(_url);
                if (!result.IsSuccessStatusCode)
                {
                    Logger.Info("Browser", "Failed getting avaliable integrations! ( network failure )", Color.White, Color.White);
                    await Task.Delay(15000);
                    continue;
                }
                var content = await result.Content.ReadAsStringAsync();

                MainPanel.BrowserIntegrationItems = JsonConvert.DeserializeObject<List<IntegrationModel>>(content);
                Logger.Info("Browser", "Loaded avaliable integrations.", Color.White, Color.White);
                await Task.Delay(50000);
            }
        }
    }
}
