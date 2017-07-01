using Microsoft.AspNetCore.Mvc;

namespace Fibon.Service.Controllers
{
    [Route("api/home")]
    public class HomeController:Controller
    {
        [HttpGet("")]
        public IActionResult Get() 
            => Content("Hello from Fibon Service");
    }
}
