using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers;

[ApiController]
[Route("api/c/[controller]")]
public class PlatformController : ControllerBase
{
    

    private readonly ILogger<PlatformController> _logger;

    public PlatformController(ILogger<PlatformController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public ActionResult TestInboundConnection()
    {
        Console.WriteLine("--> Inbound Post # From Platform Service");

        return Ok();
    }
}
