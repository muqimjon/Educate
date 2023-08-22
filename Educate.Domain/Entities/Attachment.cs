using Educate.Domain.Commons;

namespace Educate.Domain.Entities;

public class Attachment : Auditable
{
    public string FilePath { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
}
