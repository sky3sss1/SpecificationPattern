namespace Web.API.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderItemController : ControllerBase
{
    [HttpGet]
    [Route("[action]")]
    public async Task<IActionResult> Test()
    {
        return Ok("работает");
    }
}
