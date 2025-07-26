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
        /// Approve a purchase order
        /// </summary>
        /// <param name="orderId">Id of order to approve</param>
        /// <returns></returns>
        [HttpPut("purchase-orders/{orderId}/approve")]
        [Authorize(Roles = "Approver")]
        public async Task<IActionResult> ApprovePurchaseOrder(int orderId)
        {
            var approvedOrder = await _procurementService.ApprovePurchaseOrderAsync(orderId);
            return Ok(approvedOrder);
        }
        /// <summary>
        /// Reject a purchase order
        /// </summary>
        /// <param name="orderId">Id of order to reject</param>
        /// <returns></returns>
        [HttpPut("purchase-orders/{orderId}/reject")]
        [Authorize(Roles = "Approver")]
        public async Task<IActionResult> RejectPurchaseOrder(int orderId)
        {
            var rejectedOrder = await _procurementService.RejectPurchaseOrderAsync(orderId);
            return Ok(rejectedOrder);
        }
        /// <summary>
        /// List all vendors
        /// </summary>
        /// <returns></returns>
        [HttpGet("vendors")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllVendors()
        {
            var vendorList = await _procurementService.GetAllVendorsAsync();
            return Ok(vendorList);
        }
        /// <summary>
        /// Create or onboard a new vendor
        /// </summary>
        /// <param name="vendor">New Vendor to create or onboard</param>
        /// <returns></returns>
        [HttpPost("vendors")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateVendor(object vendor)
        {
            var newVendor = await _procurementService.CreateVendorAsync(vendor);
            return Ok(newVendor);
        }
        /// <summary>
        /// Get vendor details
        /// </summary>
        /// <param name="vendorId">Id of vendor to fetch</param>
        /// <returns></returns>
        [HttpGet("vendors/{vendorId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetVendorById(int vendorId)
        {
            var vendor = await _procurementService.GetVendorByIdAsync(vendorId);
            return Ok(vendor);
        }
        /// <summary>
        /// Update vendor info
        /// </summary>
        /// <param name="vendorId">Id of vendor to update</param>
        /// <param name="vendorInfo">Vendor info to update</param>
        /// <returns></returns>
        [HttpPut("vendors/{vendorId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateVendor(int vendorId, object vendorInfo)
        {
            var updatedVendor = await _procurementService.UpdateVendorAsync(vendorId, vendorInfo);
            return Ok(updatedVendor);
        }
        /// <summary>
        /// Delete a vendor
        /// </summary>
        /// <param name="vendorId">Id of vendor to delete</param>
        /// <returns></returns>
        [HttpDelete("vendors/{vendorId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteVendor(int vendorId)
        {
            await _procurementService.DeleteVendorAsync(vendorId);
            return Ok();
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
