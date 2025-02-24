namespace Infrastraction.Repositories;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(IApplicationDbContext context) : base(context) { }

    public async Task<IReadOnlyList<Order>> GetOrdersAsync(ISpecification<Order> specification)
    {
        IQueryable<Order> query = _dbSet;

        if (specification.Criteria != null)
        {
            query = query.Where(specification.Criteria);
        }

        foreach (var include in specification.Includes)
        {
            query = query.Include(include);
        }

        return await query.ToListAsync();
    }

    public async Task<Order?> GetOrderAsync(ISpecification<Order> specification)
    {
        IQueryable<Order> query = _dbSet;

        if (specification.Criteria != null)
        {
            query = query.Where(specification.Criteria);
        }

        foreach (var include in specification.Includes)
        {
            query = query.Include(include);
        }

        return await query.FirstOrDefaultAsync();
    }
}

