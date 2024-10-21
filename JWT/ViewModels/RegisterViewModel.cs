using System.ComponentModel.DataAnnotations;

namespace Identity_Api.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
