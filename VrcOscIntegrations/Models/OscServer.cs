namespace VrcOscIntegrations.Models
{
    public class OscServer
    {
        [YamlMember(Description = "If you are using that app on same machine as VRChat use \"127.0.0.1\" if its quest2 check IP of that device in router.")]
        public string IpAddress { get; set; } = "127.0.0.1";
        [YamlMember(Description = "By default port \"9999\" is used but if you changed IN port in startup arguments of VRChat then that port needs to be same.")]
        public int Port { get; set; } = 9999;
    }
}
