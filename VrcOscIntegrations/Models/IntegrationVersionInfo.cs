namespace VrcOscIntegrations.Models
{
    public class IntegrationVersionInfo
    {
        public string Version { get; set; }
        public string[] ChangeLogs { get; set; }
        public string IntegrationFileName { get; set; }
        public string DependenciesFileName { get; set; }
    }
}
