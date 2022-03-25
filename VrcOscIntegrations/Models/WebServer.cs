namespace VrcOscIntegrations.Models
{
    public class WebServer
    {
        [YamlMember(Description = "Url used for handling web requests.")]
        public string Url { get; set; } = "http://localhost:3000";
    }
}
