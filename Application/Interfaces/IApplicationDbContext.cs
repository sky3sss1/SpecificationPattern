namespace Application.Interfaces;

public interface IApplicationDbContext : IDisposable
{
    public DbSet<TEntity> Set<TEntity>() where TEntity : class;
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<User> Users { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
