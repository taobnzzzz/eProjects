using Airlines_Reservation_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Reservation_DAL.Repositories.Interfaces
{
    public interface IPaymentRepository
    {
        List<Payment> GetAllPayments();
        Payment GetPaymentById(int id);
        void AddPayment(Payment payment);
        void UpdatePayment(Payment payment);
        void DeletePayment(int id);

    }
}
