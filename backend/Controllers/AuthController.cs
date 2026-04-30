using Microsoft.AspNetCore.Mvc;

namespace ECG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] dynamic data)
        {
            return Ok(new { message = "Login Successful" });
        }
    }
}
