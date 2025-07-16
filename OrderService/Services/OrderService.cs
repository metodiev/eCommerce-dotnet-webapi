using OrderService.Repositories.Interfaces;
using OrderService.Services.Interfaces;

namespace OrderService.Services
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<bool> CancelOrderAsync(string orderId)
        {
           return await _orderRepository.CancelOrderAsync(orderId);
        }

        public async Task<bool> CreateNewOrderAsync(object order)
        {
            return await _orderRepository.CreateNewOrderAsync(order);
        }

        public async Task<List<object>> GetAllOrdersAsync()
        {
            return await _orderRepository.GetAllOrdersAsync();
        }

        public async Task<object> GetOrderByIdAsync(string orderId)
        {
            return await _orderRepository.GetOrderByIdAsync(orderId);
        }

        public async Task<List<object>> GetOrderItemsAsync(string orderId)
        {
            return await _orderRepository.GetOrderItemsAsync(orderId);
        }

        public async Task<List<object>> GetUserOrderHistoryByUserIdAsync(string userId)
        {
            return await _orderRepository.GetUserOrderHistoryByUserIdAsync(userId);
        }

        public async Task<bool> RepeatOrderAsync(string orderId)
        {
            return await _orderRepository.RepeatOrderAsync(orderId); 
        }

        public async Task<bool> UpdateOrderItemsAsync(string orderId, List<object> items)
        {
            return await _orderRepository.UpdateOrderItemsAsync(orderId, items);
        }

        public async Task<bool> UpdateOrderStatusAsync(string orderId, string status)
        {
            return await _orderRepository.UpdateOrderStatusAsync(orderId, status);
        }

        public async Task<bool> ValidateOrderAsync(string orderId)
        {
            return await _orderRepository.ValidateOrderAsync(orderId);
        }
    }
}
