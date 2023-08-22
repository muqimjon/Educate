using Educate.Domain.Commons;

namespace Educate.Domain.Entities;

public class Assigment:Auditable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public long? AttachmentId { get; set; }
    public DateTime Duration { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }

    public long CategoryId { get; set; }
    public Category Category { get; set; }
}
