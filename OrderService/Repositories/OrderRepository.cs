using OrderService.Repositories.Interfaces;

namespace OrderService.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task<bool> CancelOrderAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateNewOrderAsync(object order)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetAllOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetOrderByIdAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetOrderItemsAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetUserOrderHistoryByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RepeatOrderAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderItemsAsync(string orderId, List<object> items)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderStatusAsync(string orderId, string status)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateOrderAsync(string orderId)
        {
            throw new NotImplementedException();
        }
    }
}
