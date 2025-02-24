namespace Infrastraction.Repositories;

public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(IApplicationDbContext context) : base(context){}

    public Task<OrderItem?> GetOrderItemBySpecificationAsync(ISpecification<OrderItem> specification)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<OrderItem>> GetOrderItemsAsync(ISpecification<OrderItem> specification)
    {
        throw new NotImplementedException();
    }
}
