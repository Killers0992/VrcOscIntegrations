namespace VrcOscIntegrations
{
    public class AuthProviders
    {
        public static string TwitchClientID => "4jpzwuj55bw2g2ww9sgu8r3wmshlla";

        public static void CreateTwitchAuth(string scopes)
        {
            string redirect_uri = "http://localhost:3000/twitch/response";
            string response_type = "token";

            Process.Start(new ProcessStartInfo($"https://id.twitch.tv/oauth2/authorize?client_id={TwitchClientID}&redirect_uri={redirect_uri}&response_type={response_type}&scope={scopes}&force_verify=true") { UseShellExecute = true });
        }
    }
}
