using InventoryService.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        public Task<object> GetInventorySnapshotByWareHouseIdAsync(int warehouseId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetProductHistoryAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetStockLevelByProductIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<object> TransferStockAsync(object transferredStock)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateStockLevelAsync(int productId, object stockLevel)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> UpdateStockLevelBulkAsync(IList<object> stockLevels)
        {
            throw new NotImplementedException();
        }
    }
}
