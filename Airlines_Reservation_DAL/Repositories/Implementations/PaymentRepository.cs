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
    public class PaymentRepository : IPaymentRepository
    {
        public readonly ApplicationDbContext _context;

        public PaymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Payment> GetAllPayments()
        {
            return _context.Payments.ToList();
        }

        public Payment GetPaymentById(int id)
        {
            return _context.Payments.FirstOrDefault(p => p.PaymentId == id);
        }

        public void AddPayment(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        public void UpdatePayment(Payment payment)
        {
            _context.Payments.Update(payment);
            _context.SaveChanges();
        }

        public void DeletePayment(int id)
        {
            var payment = _context.Payments.FirstOrDefault(p => p.PaymentId == id);
            if (payment != null)
            {
                _context.Payments.Remove(payment);
                _context.SaveChanges();
            }
        }

        public List<Payment> GetPaymentsByUserId(int userId)
        {
            return _context.Payments.Where(p => p.UserId == userId).ToList();
        }
    }
}
