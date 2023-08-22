using Educate.Domain.Commons;

namespace Educate.Domain.Entities;

public class Question:Auditable
{
    public string Text { get; set; }

    public long? AttachmentId { get; set; }
    public Attachment Attachment { get; set; }

    public long AssignmentId { get; set; }
    public Assigment Assigment { get; set; }
}
