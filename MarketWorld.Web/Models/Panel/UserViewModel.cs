using System;
using System.ComponentModel.DataAnnotations;

namespace MarketWorld.Web.Models
{
    public class UserViewModel
    {
        [Display(Name = "Kullanıcı ID")]
        public string Id { get; set; }
        
        [Required(ErrorMessage = "Kullanıcı adı gereklidir")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Email adresi gereklidir")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz")]
        public string Email { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Rol seçimi gereklidir")]
        public string Role { get; set; }
        
        public bool IsActive { get; set; }
        
        public DateTime? RegistrationDate { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor")]
        public string ConfirmPassword { get; set; }
        
        public string FullName => $"{FirstName} {LastName}";
    }
} 