namespace VrcOscIntegrations.Models
{
    public class PendingUpdate
    {
        public string Id { get; set; }
        public UpdateType Type { get; set; }
        public string DisplayName { get; set; }
        public string CurrentVersion { get; set; }
        public string NewVersion { get; set; }
        public string[] Changelogs { get; set; }

        public string GithubRepo { get; set; }
        public string DependenciesFileName { get; set; }
        public string IntegrationFileName { get; set; }

        public UpdateState UpdateState { get; set; } = UpdateState.None;
    }
}
