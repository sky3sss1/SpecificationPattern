namespace Infrastraction.Repositories;

public class StatusRepository : GenericRepository<Status>, IStatusRepository
{
    public StatusRepository(IApplicationDbContext context) : base(context){}

    public Task<IReadOnlyList<Status>> GetStatusAsync(ISpecification<Status> specification)
    {
        throw new NotImplementedException();
    }

    public Task<Status?> GetStatusBySpecificationAsync(ISpecification<Status> specification)
    {
        throw new NotImplementedException();
    }
}
