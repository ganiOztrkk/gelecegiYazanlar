using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HangfireTestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]
        public IActionResult SignUp()
        {
            BackgroundJob.Enqueue(() => Ok());
            return Ok("Fire and Forget Tetiklendi");
        }
    }
}
