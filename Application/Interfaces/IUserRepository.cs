namespace Application.Interfaces;

public interface IUserRepository : IGenericRepository<User>
{
    Task<IReadOnlyList<User>> GetStatusAsync(ISpecification<User> specification);
    Task<User?> GetStatusBySpecificationAsync(ISpecification<User> specification);
}
