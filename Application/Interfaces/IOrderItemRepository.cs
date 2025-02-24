namespace Application.Interfaces;

public interface IOrderItemRepository : IGenericRepository<OrderItem>
{
    Task<IReadOnlyList<OrderItem>> GetOrderItemsAsync(ISpecification<OrderItem> specification);
    Task<OrderItem?> GetOrderItemBySpecificationAsync(ISpecification<OrderItem> specification);
}
