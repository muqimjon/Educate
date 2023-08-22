using Educate.Domain.Commons;
using Educate.Domain.Enums;

namespace Educate.Domain.Entities;

public class User : Auditable
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public UserRole Role { get; set; } = UserRole.User;
}
