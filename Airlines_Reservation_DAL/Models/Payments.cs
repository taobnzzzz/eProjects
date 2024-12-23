using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airlines_Reservation_DAL.Models
{
    [Table("Payments")]
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }

        [Required]
        public int ReservationId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal AmountPaid { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(50)]
        public string? PaymentMethod { get; set; }

        public virtual Reservation? Reservation { get; set; }
        public virtual User? User { get; set; }
    }
}
