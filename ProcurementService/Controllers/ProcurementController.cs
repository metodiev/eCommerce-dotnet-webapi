using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcurementService.Services.Interfaces;

namespace ProcurementService.Controllers.v1
{
    [Route("api/v1/procurement")]
    [ApiController]
    [Authorize]
    public class ProcurementController : ControllerBase
    {
        private readonly IProcurementService _procurementService;
        /// <summary>
        /// Should initialize the ProcurementService through dependency injection
        /// </summary>
        /// <param name="procurementService">Service handling Procurement-related business logic</param>
        public ProcurementController(IProcurementService procurementService)
        {
            _procurementService = procurementService;
        }
        /// <summary>
        /// Create a new purchase order
        /// </summary>
        /// <param name="purchaseOrder">Purchase order to create</param>
        /// <returns></returns>
        [HttpPost("purchase-orders")]
        [Authorize(Roles = "Buyer")]
        public async Task<IActionResult> CreatePurchaseOrder(object purchaseOrder)
        {
            var newOrder = await _procurementService.CreatePurchaseOrderAsync(purchaseOrder);
            return Ok(newOrder);
        }
        /// <summary>
        /// Get purchase order details by ID
        /// </summary>
        /// <param name="orderId">Id of purchase order</param>
        /// <returns></returns>
        [HttpGet("purchase-orders/{orderId}")]
        [Authorize(Roles = "Admin,Buyer")]
        public async Task<IActionResult> GetPurchaseOrderById(int orderId)
        {
            var order = await _procurementService.GetPurchaseOrderByIdAsync(orderId);
            return Ok(order);
        }
        /// <summary>
        /// List purchase orders for a user
        /// </summary>
        /// <param name="userId">Id of user to fetch purchase order for</param>
        /// <returns>Purchase orders for user</returns>
        [HttpGet("purchase-orders/user/{userId}")]
        [Authorize(Roles = "Admin,Buyer")]
        public async Task<IActionResult> GetPurchaseOrdersForUserByUserId(int userId)
        {
            var orderList = await _procurementService.GetPurchaseOrdersForUserByUserIdAsync(userId);
            return Ok(orderList);
        }
        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <returns></returns>
        [HttpGet("health")]
        [AllowAnonymous]
        public async Task<IActionResult> HealthCheck()
        {
            await _procurementService.HealthCheckAsync();
            return Ok();
        }
    }
}
