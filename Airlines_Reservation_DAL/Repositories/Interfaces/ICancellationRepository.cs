using Airlines_Reservation_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Reservation_DAL.Repositories.Interfaces
{
    public interface ICancellationRepository
    {
        List<Cancellation> GetAllCancellations();
        Cancellation GetCancellationById(int id);
        void AddCancellation(Cancellation cancellation);
        void UpdateCancellation(Cancellation cancellation);
        void DeleteCancellation(int id);

    }
}
