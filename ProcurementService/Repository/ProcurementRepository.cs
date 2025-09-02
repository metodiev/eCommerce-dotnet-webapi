using ProcurementService.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcurementService.Repository
{
    public class ProcurementRepository : IProcurementRepository
    {
        public Task<object> ApprovePurchaseOrderAsync(string orderId)
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

        public Task DeleteVendorAsync(string vendorId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllVendorsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetPurchaseOrderByIdAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetPurchaseOrdersForUserByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetVendorByIdAsync(string vendorId)
        {
            throw new NotImplementedException();
        }

        public Task HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> RejectPurchaseOrderAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateVendorAsync(string vendorId, object vendorInfo)
        {
            throw new NotImplementedException();
        }
    }
}
