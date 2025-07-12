using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InventoryService.Services.Interfaces;

namespace InventoryService.Controllers.v1
{
    [Route("api/v1/inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;
        /// <summary>
        /// Should initialize the InventoryService through dependency injection
        /// </summary>
        /// <param name="userService">Service handling Inventory-related business logic</param>
        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }
        /// <summary>
        /// Get stock level for a specific product
        /// </summary>
        /// <param name="productId">Id of product</param>
        /// <returns></returns>
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetStockLevelByProductId(int productId)
        {
            var stockLevel = await _inventoryService.GetStockLevelByProductIdAsync(productId);
            return Ok(stockLevel);
        }
        /// <summary>
        /// Update stock level (e.g., restock, manual correction)
        /// </summary>
        /// <param name="productId">Id of product</param>
        /// <param name="stockLevel">Modified stock level</param>
        /// <returns></returns>
        [HttpPut("{productId}")]
        [Authorize(Roles = "Admin,Internal")]
        public async Task<IActionResult> UpdateStockLevel(int productId, object stockLevel)
        {
            var newStockLevel = await _inventoryService.UpdateStockLevelAsync(productId);
            return Ok(newStockLevel);
        }
        /// <summary>
        /// Bulk update stock levels (e.g., via vendor feed or sync)
        /// </summary>
        /// <param name="userId">Id of user to update</param>
        /// <param name="settings">Updated user preferences</param>
        /// <returns>Newly updated user settings from database</returns>
        [HttpPut("batch-update")]
        [Authorize]
        public async Task<IActionResult> UpdateStockLevelBulk ([FromBody] IList<object> stockLevels)
        {
            var updatedSettings = await _inventoryService.UpdateStockLevelBulkAsync(stockLevels);
            return Ok(updatedSettings);
        }

        /// <summary>
        /// Get inventory snapshot for a warehouse
        /// </summary>
        /// <param name="warehouseId">Id of warehouse of the inventory snapshot to fetch</param>
        /// <returns></returns>
        [HttpGet("warehouse/{warehouseId}")]
        [Authorize]
        public async Task<IActionResult> GetInventorySnapshotByWareHouseId(int warehouseId)
        {
            var inventorySnapshot = await _inventoryService.GetInventorySnapshotByWareHouseIdAsync(warehouseId);
            return Ok(inventorySnapshot);
        }
        /// <summary>
        /// Transfer stock between warehouses
        /// </summary>
        /// <param name="transferedStock">Modified stock with different warehouse location</param>
        /// <returns></returns>
        [HttpPost("warehouse-transfer")]
        [Authorize(Roles = "Internal")]
        public async Task<IActionResult> TransferStock(object transferedStock)
        {
            var updatedStock = await _inventoryService.TransferStockAsync(transferedStock);
            return Ok(updatedStock);
        }
        /// <summary>
        /// Get inventory change history for a product
        /// </summary>
        /// <param name="productId">Id of product to fetch history for</param>
        /// <returns></returns>
        [HttpGet("{productId}/history")]
        [Authorize]
        public async Task<IActionResult> GetProductHistory(int productId)
        {
            var history = await _inventoryService.GetProductHistoryAsync(productId);
            return Ok(history);
        }
        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <returns></returns>
        [HttpGet("health")]
        public async Task<IActionResult> HealthCheck()
        {
            return Ok();
        }
    }
}
