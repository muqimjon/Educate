using Educate.Data.Contexts;
using Educate.DataAccess.IReposirtories;
using Educate.Domain.Entities;

namespace Educate.DataAccess.Repositories;

public class AttachmentRepository : Repository<Attachment>, IAttachmentRepository
{
    private readonly AppDbContext _appDbContext;
    
    public AttachmentRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
