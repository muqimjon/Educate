using Educate.Data.Contexts;
using Educate.DataAccess.IReposirtories;
using Microsoft.EntityFrameworkCore;

namespace Educate.DataAccess.Repositories;

public class UnitOfWork : IDisposable
{
    private readonly AppDbContext _appDbContext;
    public UnitOfWork()
    {
        _appDbContext = new AppDbContext();

        AnswerRepository = new AnswerRepository(_appDbContext);
        AssignmentRepository = new AssignmentRepository(_appDbContext);
        AttachmentRepository = new AttachmentRepository(_appDbContext);
        CategoryRepository = new CategoryRepository(_appDbContext);
        QuestionRepository = new QuestionRepository(_appDbContext);
        ResultRepository = new ResultRepository(_appDbContext);
        UserRepository = new UserRepository(_appDbContext);
    }

    IAnswerRepository AnswerRepository;
    IAssignmentRepository AssignmentRepository;
    IAttachmentRepository AttachmentRepository;
    ICategoryRepository CategoryRepository;
    IQuestionRepository QuestionRepository;
    IResultRepository ResultRepository;
    IUserRepository UserRepository;

    public void Dispose() => GC.SuppressFinalize(true);
}
