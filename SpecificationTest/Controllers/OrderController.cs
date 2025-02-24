namespace Web.API.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrderController(IMediator mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpGet]
    [Route("[action]")]
    public async Task<IActionResult> Test()
    {
        var result = await _mediator.Send(new GetRecentOrdersQuery());
        return Ok(result);
    }
}
