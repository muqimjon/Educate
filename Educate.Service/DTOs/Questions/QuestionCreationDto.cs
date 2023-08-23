using Educate.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Educate.Service.DTOs.Questions;

public class QuestionCreationDto
{
    [Required]
    public string Text { get; set; }
    
    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; } = default!;

    public long AssignmentId { get; set; }
    public Assignment Assignment { get; set; } = default!;
}