using ProcurementService.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcurementService.Repository
{
    public class ProcurementRepository : IProcurementRepository
    {
        public Task<object> ApprovePurchaseOrderAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<object> CreatePurchaseOrderAsync(object purchaseOrder)
        {
            throw new NotImplementedException();
        }

        public Task<object> CreateVendorAsync(object vendor)
        {
            throw new NotImplementedException();
        }

        public Task DeleteVendorAsync(int vendorId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllVendorsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetPurchaseOrderByIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetPurchaseOrdersForUserByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetVendorByIdAsync(int vendorId)
        {
            throw new NotImplementedException();
        }

        public Task HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> RejectPurchaseOrderAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateVendorAsync(int vendorId, object vendorInfo)
        {
            throw new NotImplementedException();
        }
    }
}
