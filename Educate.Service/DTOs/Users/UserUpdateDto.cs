using System.ComponentModel.DataAnnotations;

namespace Educate.Service.DTOs.Users;

public class UserUpdateDto
{
    public long Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Phone { get; set; }
    [Required]
    public string Password { get; set; }
}
