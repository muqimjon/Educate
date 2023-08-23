using Educate.Domain.Entities;

namespace Educate.Service.DTOs.Questions;

public class QuestionResultDto
{
    public long Id { get; set; }
    public string Text { get; set; }

    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; } = default!;

    public long AssignmentId { get; set; }
    public Assignment Assignment { get; set; } = default!;
}


