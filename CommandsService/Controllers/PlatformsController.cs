using System;
using Microsoft.AspNetCore.Mvc;

//4:11:38 - Starts to add on to PlatformServiceController
namespace CommandsService.Controllers;

[Route("api/c/[controller]")]
[ApiController]
public class PlatformsController : ControllerBase
{
    public PlatformsController()
    {
        
    }

    [HttpPost]
    public ActionResult TestInboundConnection()
    {
        Console.WriteLine("--> Inbound POST # Command Service");

        return Ok("Inbound test of the Platform Controller");
    }
}