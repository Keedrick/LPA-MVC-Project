using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Models
{
    public class Login
    {
        [Required]
        public string Username { get; set; } = "";

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";
    }
}
