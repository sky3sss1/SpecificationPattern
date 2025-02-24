namespace Application.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<T> AddAsync(T entity);
    Task<T[]> AddRangeAsync(T[] entity);
    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, params string[] includes);
    Task DeleteAsync(T entity);
    Task<T?> GetAsync(Expression<Func<T, bool>> predicate, params string[] includes);
    Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, params string[] includes);
    Task<T?> GetByIdAsync(object Id, params string[] includes);
    Task UpdateAsync(T entity);
}
