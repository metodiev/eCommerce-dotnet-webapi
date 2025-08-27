using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingService.Repositories.Interfaces
{
    public interface IShippingRepository
    {
        Task<string> GetShippingStatusOfOrderAsync(string orderId);
        Task<object> CreateShippingLabelAsync(string orderId);
        Task<List<object>> FetchLatestTrackingDataFromCourierAsync(string orderId);
        Task<object> CalculateShippingCostsAndTimeAsync(string orderId);
        Task<List<object>> GetSupportedCouriersAsync();
        Task<object> NotifyOfOrderDelaysAsync();
        Task<string> HealthCheckAsync();
    }
}
