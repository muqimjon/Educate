using Educate.Data.Contexts;
using Educate.DataAccess.IReposirtories;
using Educate.Domain.Entities;

namespace Educate.DataAccess.Repositories;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private readonly AppDbContext _appDbContext;

    public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
