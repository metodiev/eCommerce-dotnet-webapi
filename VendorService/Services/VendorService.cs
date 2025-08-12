using System;
using System.Collections.Generic;
using System.Text;
using VendorService.Repository.Interfaces;
using VendorService.Services.Interfaces;

namespace VendorService.Services
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _vendorRepository;
        public VendorService(IVendorRepository vendorRepository)
        {
            vendorRepository = _vendorRepository;
        }
        public async Task<IList<object>> GetProductsByVendorIdAsync(int vendorId)
        {
            return await _vendorRepository.GetProductsByVendorIdAsync(vendorId);
        }

        public async Task<IList<object>> GetRegisteredVendorsAsync()
        {
            return await _vendorRepository.GetRegisteredVendorsAsync();
        }

        public async Task<object> GetVendorDetailsByIdAsync(int vendorId)
        {
            return await _vendorRepository.GetVendorDetailsByIdAsync(vendorId);
        }

        public async Task<object> GetVendorStatusByVendorIdAsync(int vendorId)
        {
            return await _vendorRepository.GetVendorStatusByVendorIdAsync(vendorId);
        }

        public async Task HealthCheckAsync()
        {
            await _vendorRepository.HealthCheckAsync();
        }

        public async Task<IList<object>> MapVendorProductToInternalCatalogAsync(int vendorId, IList<object> vendorProducts)
        {
            return await _vendorRepository.MapVendorProductToInternalCatalogAsync(vendorId, vendorProducts);
        }

        public async Task<object> OnboardVendorAsync(object vendor)
        {
            return await _vendorRepository.OnboardVendorAsync(vendor);
        }

        public async Task<object> UpdateVendorAsync(int vendorId, object vendorInfo)
        {
            return await UpdateVendorAsync(vendorId, vendorInfo);
        }

        public async Task<IList<object>> UpdateVendorInventoryFeedAsync(int vendorId, IList<object> inventoryFeed)
        {
            return await _vendorRepository.UpdateVendorInventoryFeedAsync(vendorId, inventoryFeed);
        }
    }
}
