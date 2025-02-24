namespace Web.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("[action]")]
    public async Task<IActionResult> Test()
    {
        return Ok("работает");
    }
}
