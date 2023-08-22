using Educate.Domain.Commons;
using System.Linq.Expressions;

namespace Educate.DataAccess.IRepositories;

public interface IRepository<T> where T : Auditable
{
    Task CreateAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    void Destroy(T entity);
    Task<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null!);
    IQueryable<T> GetAll(Expression<Func<T, bool>> expression = null!, bool asNoTracking = true, string[] includes = null!);
    Task SaveAsync();
}
