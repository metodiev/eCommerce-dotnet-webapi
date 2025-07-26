using ProcurementService.Repository.Interfaces;
using ProcurementService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcurementService.Services
{
    public class ProcurementService : IProcurementService
    {
        private readonly IProcurementRepository _procurementRepository;
        public ProcurementService(IProcurementRepository procurementRepository)
        {
            _procurementRepository = procurementRepository;
        }
        public async Task<object> ApprovePurchaseOrderAsync(int orderId)
        {
            return await _procurementRepository.ApprovePurchaseOrderAsync(orderId);
        }

        public async Task<object> CreatePurchaseOrderAsync(object purchaseOrder)
        {
            return await _procurementRepository.CreatePurchaseOrderAsync(purchaseOrder);
        }

        public async Task<object> CreateVendorAsync(object vendor)
        {
            return await _procurementRepository.CreateVendorAsync(vendor);
        }

        public async Task DeleteVendorAsync(int vendorId)
        {
            await _procurementRepository.DeleteVendorAsync(vendorId);
        }

        public async Task<IList<object>> GetAllVendorsAsync()
        {
            return await _procurementRepository.GetAllVendorsAsync();
        }

        public async Task<object> GetPurchaseOrderByIdAsync(int orderId)
        {
            return await _procurementRepository.GetPurchaseOrderByIdAsync(orderId);
        }

        public async Task<IList<object>> GetPurchaseOrdersForUserByUserIdAsync(int userId)
        {
            return await _procurementRepository.GetPurchaseOrdersForUserByUserIdAsync(userId);
        }

        public Task<object> GetVendorByIdAsync(int vendorId)
        {
            return _procurementRepository.GetVendorByIdAsync(vendorId);
        }

        public async Task HealthCheckAsync()
        {
            await _procurementRepository.HealthCheckAsync();
        }

        public async Task<object> RejectPurchaseOrderAsync(int orderId)
        {
            return await _procurementRepository.RejectPurchaseOrderAsync(orderId);
        }

        public Task<object> UpdateVendorAsync(int vendorId, object vendorInfo)
        {
            return _procurementRepository.UpdateVendorAsync(vendorId, vendorInfo);
        }
    }
}
