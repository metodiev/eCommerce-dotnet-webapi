using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VendorService.Services.Interfaces;

namespace PaymentService.Controllers.v1
{
    [Route("api/v1/vendors")]
    [ApiController]
    [Authorize]
    public class VendorController : ControllerBase
    {
        private readonly IVendorService _vendorService;
        /// <summary>
        /// Should initialize the VendorService through dependency injection
        /// </summary>
        /// <param name="paymentService">Service handling Vendor-related business logic</param>
        public VendorController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }
        /// <summary>
        /// Onboard a new vendor (basic info, contract details, etc.)
        /// </summary>
        /// <param name="vendor">New Vendor to onboard</param>
        /// <returns></returns>
        [HttpPost("onboard")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> OnboardVendor(object vendor)
        {
            var onboardedVendor = await _vendorService.OnboardVendorAsync(vendor);
            return Ok(onboardedVendor);
        }
        /// <summary>
        /// Get vendor profile/details by vendor ID
        /// </summary>
        /// <param name="vendorId">Id of vendor to fetch</param>
        /// <returns></returns>
        [HttpGet("{vendorId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetVendorDetailsById(int vendorId)
        {
            var vendor = await _vendorService.GetVendorDetailsByIdAsync(vendorId);
            return Ok(vendor);
        }
        /// <summary>
        /// Update vendor information
        /// </summary>
        /// <param name="vendorId">Id of vendor to update</param>
        /// <returns></returns>
        [HttpPut("{vendorId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateVendor(int vendorId, object vendorInfo)
        {
            var updatedVendor = await _vendorService.UpdateVendorAsync(vendorId, vendorInfo);
            return Ok(updatedVendor);
        }

        /// <summary>
        /// List/search registered vendors
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetRegisteredVendors()
        {
            var vendorList = await _vendorService.GetRegisteredVendorsAsync();
            return Ok(vendorList);
        }
        /// <summary>
        /// Upload or sync vendor product inventory feed
        /// </summary>
        /// <param name="vendorId">Id of vendor whose inventory feed to update</param>
        /// <param name="inventoryFeed">Updated/synced inventory feed</param>
        /// <returns></returns>
        [HttpPost("{vendorId}/inventory-feed")]
        public async Task<IActionResult> UpdateVendorInventoryFeed(int vendorId, IList<object> inventoryFeed)
        {
            var updatedFeed = await _vendorService.UpdateVendorInventoryFeedAsync(vendorId, inventoryFeed);
            return Ok(updatedFeed);
        }
        /// <summary>
        /// Get list of products provided by vendor
        /// </summary>
        /// <param name="vendorId">Id of vendor for products</param>
        /// <returns></returns>
        [HttpGet("{vendorId}/products")]
        public async Task<IActionResult> GetProductsByVendorId(int vendorId)
        {
            var products = await _vendorService.GetProductsByVendorIdAsync(vendorId);
            return Ok(products);
        }
        /// <summary>
        /// Map vendor SKUs to internal catalog product IDs
        /// </summary>
        /// <param name="vendorId">Id of vendor</param>
        /// <param name="vendorProducts">Vendor SKUs to map</param>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpPost("{vendorId}/product-mapping")]
        [Authorize(Roles = "Internal")]
        public async Task<IActionResult> MapVendorProductToInternalCatalog(int vendorId, IList<object> vendorProducts)
        {
            var mappedProducts = await _vendorService.MapVendorProductToInternalCatalogAsync(vendorId, vendorProducts);
            return Ok(mappedProducts);
        }
        /// <summary>
        /// Get onboarding or operational status of a vendor
        /// </summary>
        /// <param name="vendorId">Id of vendor to get status for</param>
        /// <returns></returns>
        [HttpGet("{vendorId}/status")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetVendorStatusByVendorId(int vendorId)
        {
            var vendorStatus = await _vendorService.GetVendorStatusByVendorIdAsync(vendorId);
            return Ok(vendorStatus);
        }
        [HttpGet("health")]
        [AllowAnonymous]
        public async Task<IActionResult> HealthCheck()
        {
            return Ok();
        }
    }
}
