using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airlines_Reservation_DAL.Models
{
    [Table("Reservations")]
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservationId { get; set; }

        [Required]
        [ForeignKey("User")] // Liên kết với bảng Users
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Flight")] // Liên kết với bảng Flights
        public int FlightId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "TravelersCount must be at least 1.")]
        public int TravelersCount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        [Range(0, double.MaxValue, ErrorMessage = "TotalCost must be a positive value.")]
        public decimal TotalCost { get; set; }

        [Required]
        [MaxLength(50)]
        public string ConfirmationNumber { get; set; } = Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper(); // Tự động tạo mã xác nhận

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ReservationDate { get; set; } = DateTime.UtcNow; // Sử dụng giờ UTC mặc định

        // Điều hướng tới User
        public virtual User? User { get; set; }

        // Điều hướng tới Flight
        public virtual Flight? Flight { get; set; }
    }
}
