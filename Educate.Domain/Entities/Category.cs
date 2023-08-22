using Educate.Domain.Commons;

namespace Educate.Domain.Entities;

public class Category : Auditable
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public long? ParentId { get; set; }
}

