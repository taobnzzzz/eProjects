using Airlines_Reservation_DAL.DataContext;
using Airlines_Reservation_DAL.Models;
using Airlines_Reservation_DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Reservation_DAL.Repositories.Implementations
{
    public class CancellationRepository : ICancellationRepository
    {
        public readonly ApplicationDbContext _context;

        public CancellationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Cancellation> GetAllCancellations()
        {
            return _context.Cancellations.ToList();
        }

        public Cancellation GetCancellationById(int id)
        {
            return _context.Cancellations.FirstOrDefault(c => c.CancellationId == id);
        }

        public void AddCancellation(Cancellation cancellation)
        {
            _context.Cancellations.Add(cancellation);
            _context.SaveChanges();
        }

        public void UpdateCancellation(Cancellation cancellation)
        {
            _context.Cancellations.Update(cancellation);
            _context.SaveChanges();
        }

        public void DeleteCancellation(int id)
        {
            var cancellation = _context.Cancellations.FirstOrDefault(c => c.CancellationId == id);
            if (cancellation != null)
            {
                _context.Cancellations.Remove(cancellation);
                _context.SaveChanges();
            }
        }
    }
}
