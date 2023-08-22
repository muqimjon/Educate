using Educate.Domain.Commons;
using Educate.Data.DbContexts;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Educate.DataAccess.IRepositories;

namespace Educate.DataAccess.Repositories;

public class Repository<T> : IRepository<T> where T : Auditable
{
    private readonly DbSet<T> dbSet;
    private readonly AppDbContext appDbContext;

    public Repository(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
        dbSet = appDbContext.Set<T>();
    }

    public async Task CreateAsync(T entity)
    {
        await dbSet.AddAsync(entity);
    }

    public void Update(T entity)
    {
        entity.UpdatedAt = DateTime.UtcNow;
        dbSet.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(T entity)
    {
        entity.IsDeleted = true;
    }

    public void Destroy(T entity)
    {
        dbSet.Remove(entity);
    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null!)
    {
        var query = expression is null ? dbSet : dbSet.Where(expression);

        if (includes is not null)
            foreach (var include in includes)
                query = query.Include(include);

        var result = await query.FirstOrDefaultAsync(expression!);
        return result!;
    }

    public IQueryable<T> GetAll(Expression<Func<T, bool>> expression = null!, bool asNoTracking = true, string[] includes = null!)
    {
        var query = expression is null ? dbSet : dbSet.Where(expression);
        query = asNoTracking ? query.AsNoTracking() : query;

        if (includes is not null)
            foreach (var include in includes)
                query = query.Include(include);

        return query;
    }

    public async Task SaveAsync()
    {
        await appDbContext.SaveChangesAsync();
    }
}
