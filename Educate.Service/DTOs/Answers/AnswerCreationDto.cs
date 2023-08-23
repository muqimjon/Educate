using Educate.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Educate.Service.DTOs.Answers;

public class AnswerCreationDto
{
    [Required]
    public string Text { get; set; }
    public bool IsTrue { get; set; }

    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; } = default!;

    public long QuestionId { get; set; }
    public Question Question { get; set; } = default!;
}