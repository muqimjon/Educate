using Educate.Domain.Commons;

namespace Educate.Domain.Entities;

public class Assignment : Auditable
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public long AttachmentId { get; set; }
    public DateTime Duration { get; set; }

    public long UserId { get; set; }
    public User User { get; set; } = default!;

    public long CategoryId { get; set; }
    public Category Category { get; set; } = default!;
}
