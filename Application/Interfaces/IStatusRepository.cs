namespace Application.Interfaces;

public interface IStatusRepository : IGenericRepository<Status>
{
    Task<IReadOnlyList<Status>> GetStatusAsync(ISpecification<Status> specification);
    Task<Status?> GetStatusBySpecificationAsync(ISpecification<Status> specification);
}
