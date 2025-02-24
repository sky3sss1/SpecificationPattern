namespace Infrastraction;

public class UnitOfWork : IUnitOfWork
{
    private readonly IApplicationDbContext _context;

    public UnitOfWork(IApplicationDbContext context,
                      IOrderRepository orderRepository,
                      IOrderItemRepository orderItemRepository,
                      IUserRepository userRepository,
                      IStatusRepository statusRepository)
    {
        _context = context;
        Orders = orderRepository;
        OrderItems = orderItemRepository;
        Users = userRepository;
        Statuses = statusRepository;
    }

    public IOrderRepository Orders { get; }
    public IOrderItemRepository OrderItems { get; }
    public IUserRepository Users { get; }
    public IStatusRepository Statuses { get; }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
