using Educate.Domain.Entities;

namespace Educate.Service.DTOs.Answers;

public class AnswerUpdateDto
{
    public long Id { get; set; }
    public string Text { get; set; }
    public bool IsTrue { get; set; }

    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; } = default!;

    public long QuestionId { get; set; }
    public Question Question { get; set; } = default!;
}
