using Educate.Data.Contexts;
using Educate.DataAccess.IReposirtories;
using Educate.Domain.Entities;

namespace Educate.DataAccess.Repositories;

public class AnswerRepository : Repository<Answer>, IAnswerRepository
{
    private readonly AppDbContext _appDbContext;
    
    public AnswerRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
