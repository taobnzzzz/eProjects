using Airlines_Reservation_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Reservation_DAL.Repositories.Interfaces
{
    public interface IReservationRepository
    {
        List<Reservation> GetAllReservations();
        Reservation GetReservationById(int id);
        void AddReservation(Reservation reservation);
        void UpdateReservation(Reservation reservation);
        void DeleteReservation(int id);

    }
}
