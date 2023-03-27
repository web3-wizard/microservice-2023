using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/platforms")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
            
        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            System.Console.WriteLine(" --> Inbound post # Command Service");

            return Ok("Inbound test of from Platforms Controller");
        }
    }
}