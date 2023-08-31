using Educate.Data.Contexts;
using Educate.DataAccess.IReposirtories;
using Educate.Domain.Entities;

namespace Educate.DataAccess.Repositories;

public class AssignmentRepository : Repository<Assignment>, IAssignmentRepository
{
    private readonly AppDbContext _appDbContext;

    public AssignmentRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
