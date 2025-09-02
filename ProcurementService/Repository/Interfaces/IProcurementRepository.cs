using System;
using System.Collections.Generic;
using System.Text;

namespace ProcurementService.Repository.Interfaces
{
    public interface IProcurementRepository
    {
        Task<object> ApprovePurchaseOrderAsync(string orderId);
        Task<object> CreatePurchaseOrderAsync(object purchaseOrder);
        Task<object> CreateVendorAsync(object vendor);
        Task DeleteVendorAsync(string vendorId);
        Task<IList<object>> GetAllVendorsAsync();
        Task<object> GetPurchaseOrderByIdAsync(string orderId);
        Task<IList<object>> GetPurchaseOrdersForUserByUserIdAsync(string userId);
        Task<object> GetVendorByIdAsync(string vendorId);
        Task HealthCheckAsync();
        Task<object> RejectPurchaseOrderAsync(string orderId);
        Task<object> UpdateVendorAsync(string vendorId, object vendorInfo);
    }
}
