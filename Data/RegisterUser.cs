using System.ComponentModel.DataAnnotations;

namespace helloweb.Data{
    public class RegisterUser{
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
    }
}