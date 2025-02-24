namespace Application.Features.Orders.Commands;

public class AddOrderCommand : IRequest
{
    public AddOrderCommand(Order order)
    {
        Order = order;
    }

    public Order Order { get; set; }
}
