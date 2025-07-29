using PaymentService.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        public Task<object> AddPaymentMethodForUserAsync(object paymentMethod)
        {
            throw new NotImplementedException();
        }

        public Task<object> CreatePaymentTransactionAsync(object payment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSavedPaymentMethodAsync(int methodId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllPaymentsByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task GetExternalPaymentProvidersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetPaymentDetailsByIdAsync(int paymentId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetPaymentMethodsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> RefundPaymentAsync(int paymentId)
        {
            throw new NotImplementedException();
        }

        public Task ValidatePaymentAsync(object validatedPayment)
        {
            throw new NotImplementedException();
        }
    }
}
