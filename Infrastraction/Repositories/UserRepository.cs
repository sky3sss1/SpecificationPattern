namespace Infrastraction.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(IApplicationDbContext context) : base(context){}

    public Task<IReadOnlyList<User>> GetStatusAsync(ISpecification<User> specification)
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetStatusBySpecificationAsync(ISpecification<User> specification)
    {
        throw new NotImplementedException();
    }
}
