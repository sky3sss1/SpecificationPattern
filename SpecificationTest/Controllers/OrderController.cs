using Application.Features.Orders.Commands;
using Web.API.Models;

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

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> AddOrderWithOrderItems(AddOrderAndOrderItemsModel model)
    {
        await _mediator.Send(model.ToCommand());
        return Ok();
    }
}
