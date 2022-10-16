using Microsoft.AspNetCore.Mvc;

namespace TestRepository.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    public ItemController()
    {
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}