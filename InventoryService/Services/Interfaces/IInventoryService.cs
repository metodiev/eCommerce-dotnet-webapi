using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Services.Interfaces
{
    public interface IInventoryService
    {
        Task<object> GetInventorySnapshotByWareHouseIdAsync(int warehouseId);
        Task<IList<object>> GetProductHistoryAsync(int productId);
        Task<object> GetStockLevelByProductIdAsync(int productId);
        Task<object> TransferStockAsync(object transferredStock);
        Task<object> UpdateStockLevelAsync(int productId, object stockLevel);
        Task<IList<object>> UpdateStockLevelBulkAsync(IList<object> vendors);
    }
}
