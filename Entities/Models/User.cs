using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airlines_Reservation_DAL.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string? FullName { get; set; }

        public string? Address { get; set; }

        [StringLength(15)]
        public string? PhoneNumber { get; set; }

        [StringLength(20)]
        public string? PreferredCreditCardNumber { get; set; }

        public int SkyMiles { get; set; } = 0;
    }
}
