using Microsoft.AspNetCore.Mvc;

namespace DaprCronBinding.Controllers
{
    [ApiController]
    [Route("")]
    public class SomeController : ControllerBase
    {
        private readonly ILogger<SomeController> _logger;

        public SomeController(ILogger<SomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/action")]
        public ActionResult Action()
        {
            _logger.LogInformation("Action executed!!!");

            return Ok();
        }
    }
}
