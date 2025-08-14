using PaymentService.Repository.Interfaces;
using PaymentService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        public async Task<object> AddPaymentMethodForUserAsync(object paymentMethod)
        {
            return await _paymentRepository.AddPaymentMethodForUserAsync(paymentMethod);
        }

        public async Task<object> CreatePaymentTransactionAsync(object payment)
        {
            return await _paymentRepository.CreatePaymentTransactionAsync(payment);
        }

        public async Task DeleteSavedPaymentMethodAsync(int methodId)
        {
            await _paymentRepository.DeleteSavedPaymentMethodAsync(methodId);
        }

        public async Task<IList<object>> GetAllPaymentsByUserIdAsync(int userId)
        {
            return await _paymentRepository.GetAllPaymentsByUserIdAsync(userId);
        }

        public async Task GetExternalPaymentProvidersAsync()
        {
            await _paymentRepository.GetExternalPaymentProvidersAsync();
        }

        public async Task<object> GetPaymentDetailsByIdAsync(int paymentId)
        {
            return await _paymentRepository.GetPaymentDetailsByIdAsync(paymentId);
        }

        public async Task<IList<object>> GetPaymentMethodsAsync()
        {
            return await _paymentRepository.GetPaymentMethodsAsync();
        }

        public async Task<object> RefundPaymentAsync(int paymentId)
        {
            return await _paymentRepository.RefundPaymentAsync(paymentId);
        }

        public async Task ValidatePaymentAsync(object validatedPayment)
        {
            await ValidatePaymentAsync(validatedPayment);
        }
    }
}
