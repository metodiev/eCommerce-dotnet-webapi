using ShippingService.Repositories.Interfaces;

namespace ShippingService.Repositories
{
    public class ShippingRepository : IShippingRepository
    {
        public Task<object> CalculateShippingCostsAndTimeAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<object> CreateShippingLabelAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> FetchLatestTrackingDataFromCourierAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetShippingStatusOfOrderAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetSupportedCouriersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> NotifyOfOrderDelaysAsync()
        {
            throw new NotImplementedException();
        }
    }
}
