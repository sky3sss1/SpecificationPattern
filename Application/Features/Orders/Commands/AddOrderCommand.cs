namespace Application.Features.Orders.Commands;

public class AddOrderCommand : IRequest
{
    public AddOrderCommand(Order order, IReadOnlyList<OrderItem> orderItems)
    {
        Order = order;
        OrderItems = orderItems;
    }

    public Order Order { get; set; }
    public IReadOnlyList<OrderItem> OrderItems { get; set; }    
}
