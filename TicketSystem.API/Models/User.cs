using System.ComponentModel.DataAnnotations;

namespace TicketSystem.API.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; } // User / Admin

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
