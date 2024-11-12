using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_App.Services;

namespace ASP.NET_Core_App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KCBController : Controller
    {
        private readonly KCB _kcbService;

        public KCBController(KCB kcbService)
        {
            _kcbService = kcbService;
        }

        [HttpGet("token")]
        public async Task<IActionResult> GetToken([FromQuery] string username, [FromQuery] string password)
        {
            var (accessToken, tokenType, expiresIn) = await _kcbService.FetchTokenAsync(username, password);

            // Returning each value independently in JSON format
            return Ok(new
            {
                access_token = accessToken,
                token_type = tokenType,
                expires_in = expiresIn
            });
        }
    }
}
