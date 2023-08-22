using Educate.Domain.Commons;

namespace Educate.Domain.Entities
{
    public class Result : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; } = default!;

        public long QuestionId { get; set; }
        public Question Question { get; set; } = default!;

        public long AnswerId { get; set; }
        public Answer Answer { get; set; } = default!;
    }
}
