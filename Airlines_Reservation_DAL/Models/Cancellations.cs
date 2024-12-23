using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airlines_Reservation_DAL.Models
{
    [Table("Cancellations")]
    public class Cancellation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CancellationId { get; set; }

        [Required]
        public int ReservationId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal RefundAmount { get; set; }

        [Required]
        [MaxLength(50)]
        public string? CancellationNumber { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CancellationDate { get; set; } = DateTime.Now;
        public virtual Reservation? Reservation { get; set; }
    }
}
