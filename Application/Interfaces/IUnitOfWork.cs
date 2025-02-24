namespace Application.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IOrderRepository Orders { get; }
    IOrderItemRepository OrderItems {get;}
    IUserRepository Users {get;}
    IStatusRepository Statuses { get;}

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
