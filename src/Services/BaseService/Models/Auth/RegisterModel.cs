using System.ComponentModel.DataAnnotations;

namespace BaseService.Models.Auth;

public class RegisterModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;
    public string UserName { get; set; } = null!;

    [Required]
    [StringLength(100, MinimumLength = 6)]
    public string Password { get; set; } = null!;

    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; } = null!;

    [Required]
    public string FirstName { get; set; } = null!;

    [Required]
    public string LastName { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    
    [Required]
    public string RoleId { get; set; } = null!; // AspNetRoles tablosundaki Id değeri
} 