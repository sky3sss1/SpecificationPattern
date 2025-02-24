namespace Application.Features.Orders.Queries;

public class GetRecentOrdersQueryHandler : IRequestHandler<GetRecentOrdersQuery, IReadOnlyList<Order>>
{
    private readonly IOrderRepository _orderRepository;

    public GetRecentOrdersQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
    }

    public async Task<IReadOnlyList<Order>> Handle(GetRecentOrdersQuery request, CancellationToken cancellationToken)
    {
        return await _orderRepository.GetOrdersAsync(new RecentOrdersSpecification());
    }
}