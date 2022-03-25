namespace TwitchIntegration.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet("~/twitch/response")]
        public IActionResult TwitchResponse() => View("TwitchResponse");
    }
}
