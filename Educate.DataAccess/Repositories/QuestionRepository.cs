using Educate.Data.Contexts;
using Educate.DataAccess.IReposirtories;
using Educate.Domain.Entities;

namespace Educate.DataAccess.Repositories;

public class QuestionRepository : Repository<Question>, IQuestionRepository
{
    private readonly AppDbContext _appDbContext;

    public QuestionRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
