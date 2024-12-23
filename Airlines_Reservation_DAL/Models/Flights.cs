using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airlines_Reservation_DAL.Models
{
    [Table("Flights")]
    public class Flight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FlightId { get; set; }

        [Required]
        [MaxLength(10)]
        public string? FlightNumber { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }

        [Required]
        public TimeSpan DepartureTime { get; set; }

        [Required]
        public TimeSpan ArrivalTime { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Origin { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Destination { get; set; }

        [Required]
        public int TotalSeats { get; set; }

        [Required]
        public int AvailableSeats { get; set; }
    }
}
