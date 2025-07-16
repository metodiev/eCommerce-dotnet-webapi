namespace OrderService.Services.Interfaces
{
    public interface IOrderService
    {
        Task<bool> CreateNewOrderAsync(object order);
        Task<object> GetOrderByIdAsync(string orderId);
        Task<List<object>> GetUserOrderHistoryByUserIdAsync(string userId);
        Task<bool> UpdateOrderStatusAsync(string orderId, string status);
        Task<List<object>> GetAllOrdersAsync();
        Task<bool> CancelOrderAsync(string orderId);
        Task<bool> RepeatOrderAsync(string orderId);
        Task<List<object>> GetOrderItemsAsync(string orderId);
        Task<bool> UpdateOrderItemsAsync(string orderId, List<object> items);
        Task<bool> ValidateOrderAsync(string orderId);
    }
}
