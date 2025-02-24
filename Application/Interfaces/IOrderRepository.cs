namespace Application.Interfaces;

public interface IOrderRepository : IGenericRepository<Order>
{
    Task<IReadOnlyList<Order>> GetOrdersAsync(ISpecification<Order> specification);
    Task<Order?> GetOrderAsync(ISpecification<Order> specification);
}
