namespace Infrastraction.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly IApplicationDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public GenericRepository(IApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public async Task<T[]> AddRangeAsync(T[] entities)
    {
        await _dbSet.AddRangeAsync(entities);
        return entities;
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, params string[] includes)
    {
        IQueryable<T> query = _dbSet;
        foreach (var include in includes)
        {
            query = query.Include(include);
        }
        return await query.AnyAsync(predicate);
    }

    public async Task DeleteAsync(T entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, params string[] includes)
    {
        IQueryable<T> query = _dbSet;
        foreach (var include in includes)
        {
            query = query.Include(include);
        }

        return predicate == null
            ? await query.ToListAsync()
            : await query.Where(predicate).ToListAsync();
    }

    public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate, params string[] includes)
    {
        IQueryable<T> query = _dbSet;
        foreach (var include in includes)
        {
            query = query.Include(include);
        }
        return await query.FirstOrDefaultAsync(predicate);
    }

    public Task<T?> GetByIdAsync(object Id, params string[] includes)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
    }
}