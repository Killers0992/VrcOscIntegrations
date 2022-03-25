using CoreOSC;

namespace VrcOscIntegrations.Interfaces
{
    public interface IVrcIntegration<out TConfig> where TConfig : IConfig
    {
        string Id { get; }
        string Name { get; }
        string Author { get; }
        Version Version { get; }
        IntegrationStatus Status { get; set; }
        string IntegrationPath { get; set; }
        PoisonUserControl MainPanel { get; }
        void OnRegister(ref IServiceCollection services);
        void OnEnable();
        IConfig OnCreateDefaultConfig();
        void OnReceiveOscMessage(string address, OscMessage message);
        void SaveConfig();
        TConfig Config { get; }
    }
}
