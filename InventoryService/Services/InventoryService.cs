using InventoryService.Repository.Interfaces;
using InventoryService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;
        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }
        //further down the line when more complex proper business logic is defined service methods won't just call corresponding repository methods
        public async Task<object> GetInventorySnapshotByWareHouseIdAsync(int warehouseId)
        {
            return await _inventoryRepository.GetInventorySnapshotByWareHouseIdAsync(warehouseId);
        }

        public async Task<IList<object>> GetProductHistoryAsync(int productId)
        {
            return await _inventoryRepository.GetProductHistoryAsync(productId);
        }

        public async Task<object> GetStockLevelByProductIdAsync(int productId)
        {
            return await _inventoryRepository.GetStockLevelByProductIdAsync(productId);
        }

        public async Task<object> TransferStockAsync(object transferredStock)
        {
            return await _inventoryRepository.TransferStockAsync(transferredStock);
        }

        public async Task<object> UpdateStockLevelAsync(int productId, object stockLevel)
        {
            return await _inventoryRepository.UpdateStockLevelAsync(productId, stockLevel);
        }

        public async Task<IList<object>> UpdateStockLevelBulkAsync(IList<object> vendors)
        {
            return await _inventoryRepository.UpdateStockLevelBulkAsync(vendors);
        }
    }
}
