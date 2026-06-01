using System.ComponentModel.DataAnnotations;

namespace PruebaDesarrollo.Models
{
    public class Usuario
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
