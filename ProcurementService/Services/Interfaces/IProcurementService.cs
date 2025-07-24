using System;
using System.Collections.Generic;
using System.Text;

namespace ProcurementService.Services.Interfaces
{
    public interface IProcurementService
    {
        Task<object> CreatePurchaseOrderAsync(object purchaseOrder);
        Task<object> GetPurchaseOrderByIdAsync(int orderId);
        Task<IList<object>> GetPurchaseOrdersForUserByUserIdAsync(int userId);
        Task HealthCheckAsync();
    }
}
