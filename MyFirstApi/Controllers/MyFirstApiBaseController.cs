using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MyFirstApiBaseController : ControllerBase
    {
        public string Author { get; set; } = "Theo Rondon";

        [HttpGet("heathy")]
        public IActionResult Heathy()
        {
            return Ok("It's working");
        }

        protected string GetCustomKey()
        {
            return Request.Headers["MyKey"].ToString();
        }
    }
}
 