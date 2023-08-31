using Educate.Data.Contexts;
using Educate.DataAccess.IReposirtories;
using Educate.Domain.Entities;

namespace Educate.DataAccess.Repositories;

public class ResultRepository : Repository<Result>, IResultRepository
{
    private readonly AppDbContext _appDbContext;

    public ResultRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
