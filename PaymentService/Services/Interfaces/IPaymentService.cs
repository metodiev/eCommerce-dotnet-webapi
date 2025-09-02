using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<object> AddPaymentMethodForUserAsync(object paymentMethod);
        Task<object> CreatePaymentTransactionAsync(object payment);
        Task DeleteSavedPaymentMethodAsync(int methodId);
        Task<IList<object>> GetAllPaymentsByUserIdAsync(int userId);
        Task GetExternalPaymentProvidersAsync();
        Task<object> GetPaymentDetailsByIdAsync(int paymentId);
        Task<IList<object>> GetPaymentMethodsAsync();
        Task<object> RefundPaymentAsync(int paymentId);
        Task ValidatePaymentAsync(object validatedPayment);

    }
}
