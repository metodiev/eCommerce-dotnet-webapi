using ShippingService.Repositories.Interfaces;
using ShippingService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingService.Services
{
    public class ShippingService : IShippingService
    {
        private readonly IShippingRepository _shippingRepository;
        public ShippingService(IShippingRepository shippingRepository)
        {
            _shippingRepository = shippingRepository;
        }
        public async Task<object> CalculateShippingCostsAndTimeAsync(string orderId)
        {
            return await _shippingRepository.CalculateShippingCostsAndTimeAsync(orderId);
        }

        public async Task<object> CreateShippingLabelAsync(string orderId)
        {
            return await _shippingRepository.CreateShippingLabelAsync(orderId);
        }

        public async Task<List<object>> FetchLatestTrackingDataFromCourierAsync(string orderId)
        {
            return await _shippingRepository.FetchLatestTrackingDataFromCourierAsync(orderId);
        }

        public async Task<string> GetShippingStatusOfOrderAsync(string orderId)
        {
            return await _shippingRepository.GetShippingStatusOfOrderAsync(orderId);
        }

        public async Task<List<object>> GetSupportedCouriersAsync()
        {
            return await _shippingRepository.GetSupportedCouriersAsync();
        }

        public async Task<string> HealthCheckAsync()
        {
            return await _shippingRepository.HealthCheckAsync();
        }

        public async Task<object> NotifyOfOrderDelaysAsync()
        {
            return await _shippingRepository.NotifyOfOrderDelaysAsync();
        }
    }
}
