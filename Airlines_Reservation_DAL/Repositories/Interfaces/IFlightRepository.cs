using Airlines_Reservation_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Reservation_DAL.Repositories.Interfaces
{
    public interface IFlightRepository
    {
        List<Flight> GetAllFlights();
        Flight GetFlightById(int id);
        void AddFlight(Flight flight);
        void UpdateFlight(Flight flight);
        void DeleteFlight(int id);

    }
}
