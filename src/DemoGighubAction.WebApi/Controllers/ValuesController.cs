using Microsoft.AspNetCore.Mvc;

namespace DemoGighubAction.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Hello world");
        }
    }

}