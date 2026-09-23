

using System.ComponentModel.DataAnnotations;

namespace Finance_app.DTOs.Account
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]

        public string Password { get; set; }
    }
}
