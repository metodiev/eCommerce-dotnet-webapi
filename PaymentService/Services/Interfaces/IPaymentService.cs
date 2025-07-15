using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<object> CreatePaymentTransactionAsync(object payment);
        Task<IList<object>> GetAllPaymentsByUserIdAsync(int userId);
        Task<object> GetPaymentDetailsByIdAsync(int paymentId);
        Task<object> RefundPaymentAsync(int paymentId);
    }
}
