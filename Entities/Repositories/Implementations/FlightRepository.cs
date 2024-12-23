using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines_Reservation_DAL.DataContext;
using Airlines_Reservation_DAL.Models;
using Airlines_Reservation_DAL.Repositories.Interfaces;

namespace Airlines_Reservation_DAL.Repositories.Implementations
{
    public class FlightRepository : IFlightRepository
    {
        public readonly ApplicationDbContext _context;

        public FlightRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Flight> GetAllFlights()
        {
            return _context.Flights.ToList();
        }

        public Flight GetFlightById(int id)
        {
            return _context.Flights.FirstOrDefault(f => f.FlightId == id);
        }

        public void AddFlight(Flight flight)
        {
            _context.Flights.Add(flight);
            _context.SaveChanges();
        }

        public void UpdateFlight(Flight flight)
        {
            _context.Flights.Update(flight);
            _context.SaveChanges();
        }

        public void DeleteFlight(int id)
        {
            var flight = _context.Flights.FirstOrDefault(f => f.FlightId == id);
            if (flight != null)
            {
                _context.Flights.Remove(flight);
                _context.SaveChanges();
            }
        }

    }
}