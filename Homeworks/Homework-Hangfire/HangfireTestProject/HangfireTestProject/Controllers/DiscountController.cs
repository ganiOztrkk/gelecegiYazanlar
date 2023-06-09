using System;
using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HangfireTestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]
        public IActionResult Discount()
        {
            BackgroundJob.Schedule(() => Ok(), TimeSpan.FromSeconds(10));
            return Ok("Delayed Job Çalıştı.");
        }
    }
}
