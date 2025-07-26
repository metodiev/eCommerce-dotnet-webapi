using System;
using System.Collections.Generic;
using System.Text;

namespace ProcurementService.Services.Interfaces
{
    public interface IProcurementService
    {
        Task<object> ApprovePurchaseOrderAsync(int orderId);
        Task<object> CreatePurchaseOrderAsync(object purchaseOrder);
        Task<object> CreateVendorAsync(object vendor);
        Task DeleteVendorAsync(int vendorId);
        Task<IList<object>> GetAllVendorsAsync();
        Task<object> GetPurchaseOrderByIdAsync(int orderId);
        Task<IList<object>> GetPurchaseOrdersForUserByUserIdAsync(int userId);
        Task<object> GetVendorByIdAsync(int vendorId);
        Task HealthCheckAsync();
        Task<object> RejectPurchaseOrderAsync(int orderId);
        Task<object> UpdateVendorAsync(int vendorId, object vendorInfo);
    }
}
