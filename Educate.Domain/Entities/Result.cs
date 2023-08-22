using Educate.Domain.Commons;

namespace Educate.Domain.Entities
{
    public class Result:Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public long QuestionId { get; set; }
        public Question Question { get; set; }

        public long AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
