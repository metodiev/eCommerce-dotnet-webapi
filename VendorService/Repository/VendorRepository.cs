using System;
using System.Collections.Generic;
using System.Text;
using VendorService.Repository.Interfaces;

namespace VendorService.Repository
{
    public class VendorRepository : IVendorRepository
    {
        public Task<IList<object>> GetProductsByVendorIdAsync(int vendorId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetRegisteredVendorsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetVendorDetailsByIdAsync(int vendorId)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetVendorStatusByVendorIdAsync(int vendorId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> MapVendorProductToInternalCatalogAsync(int vendorId, IList<object> vendorProducts)
        {
            throw new NotImplementedException();
        }

        public Task<object> OnboardVendorAsync(object vendor)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateVendorAsync(int vendorId, object vendorInfo)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> UpdateVendorInventoryFeedAsync(int vendorId, IList<object> inventoryFeed)
        {
            throw new NotImplementedException();
        }
    }
}
