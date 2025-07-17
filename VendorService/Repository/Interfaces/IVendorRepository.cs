using System;
using System.Collections.Generic;
using System.Text;

namespace VendorService.Repository.Interfaces
{
    public interface IVendorRepository
    {
        Task<IList<object>> GetProductsByVendorIdAsync(int vendorId);
        Task<IList<object>> GetRegisteredVendorsAsync();
        Task<object> GetVendorDetailsByIdAsync(int vendorId);
        Task<object> GetVendorStatusByVendorIdAsync(int vendorId);
        Task<IList<object>> MapVendorProductToInternalCatalogAsync(int vendorId, IList<object> vendorProducts);
        Task<object> OnboardVendorAsync(object vendor);
        Task<object> UpdateVendorAsync(int vendorId, object vendorInfo);
        Task<IList<object>> UpdateVendorInventoryFeedAsync(int vendorId, IList<object> inventoryFeed);
    }
}
