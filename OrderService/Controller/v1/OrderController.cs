using Microsoft.AspNetCore.Mvc;
using OrderService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderService.Controller.v1
{
    [ApiController]
    [Route("api/v1/orders")]
    public class OrderController: ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }


        /// <summary>
        /// The endpoint used to create a new order.
        /// </summary>
        /// <returns>Confirmation that order was created</returns>
        [HttpPost]
        public async Task<IActionResult> CreateNewOrder([FromBody] object order)
        {
            await _orderService.CreateNewOrderAsync(order);
            return Ok();
        }


        /// <summary>
        /// Retrieve a specific order by its Id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns> An Order object. </returns>
        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetOrderById(string orderId)
        {
            await _orderService.GetOrderByIdAsync(orderId);
            return Ok();
        }


        /// <summary>
        /// Retrieve the order history of a specific user by their Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns> A List of Order objects </returns>
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetUserOrderHistoryByUserId(string userId)
        {
            await _orderService.GetUserOrderHistoryByUserIdAsync(userId);
            return Ok();
        }


        /// <summary>
        /// Update the status of an order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>Confirmation that the status was updated </returns>
        [HttpPut("{orderId}/status")]
        public async Task<IActionResult> UpdateOrderStatus(string orderId, string status)
        {
            await _orderService.UpdateOrderStatusAsync(orderId, status);
            return Ok();
        }
        
        
        /// <summary>
        /// Retrieves a list of all orders
        /// </summary>
        /// <returns>A List of Order objects </returns>
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            await _orderService.GetAllOrdersAsync();
            return Ok();
        }

        /// <summary>
        /// Cancels a the order with the provided Id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>Confirmation that the order was canceled </returns>
        [HttpDelete("{orderId}")]
        public async Task<IActionResult> CancelOrder(string orderId)
        {
            await _orderService.CancelOrderAsync(orderId);
            return Ok();
        }

        /// <summary>
        /// Creates a new order, identical to a previously existing one
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns> Confirmation that the order was created </returns>
        [HttpPost("{orderId}/repeat")]
        public async Task<IActionResult> RepeatOrder(string orderId)
        {
            await _orderService.RepeatOrderAsync(orderId);
            return Ok();
        }

        /// <summary>
        /// Retrieves a list of a specific order's items
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>A list of OrderItem objects</returns>
        [HttpGet("{orderId}/items")]
        public async Task<IActionResult> GetOrderItems(string orderId)
        {
            await _orderService.GetOrderItemsAsync(orderId);
            return Ok();
        }


        /// <summary>
        /// Updates the items linked to a specific order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>Confirmation that the order items were updated</returns>
        [HttpPut("{orderId}/items")]
        public async Task<IActionResult> UpdateOrderItems(string orderId,[FromBody] List<object> items)
        {
            await _orderService.UpdateOrderItemsAsync(orderId, items);
            return Ok();
        }

        /// <summary>
        /// Validates an order before it being submitted or marked as "Active"
        /// </summary>
        /// <returns> Confirmation that order was confirmed </returns>
        [HttpPost("{orderId}/validate")]
        public async Task<IActionResult> ValidateOrder(string orderId)
        {
            await _orderService.ValidateOrderAsync(orderId);
            return Ok();
        }
    }
}
