using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductService.Services.Interfaces;

namespace ProductService.Controllers.v1
{
    [Route("api/v1/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        /// <summary>
        /// Should initialize the ProductService through dependency injection
        /// </summary>
        /// <param name="ProductService">Service handling Product-related business logic</param>
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        /// <summary>
        /// Retrieve a paginated list of products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPaginatedProducts()
        {
            var productsList = await _productService.GetPaginatedProductsAsync();
            return Ok(productsList);
        }
        /// <summary>
        /// Get full details of a specific product
        /// </summary>
        /// <param name="productId">Id of product to fetch</param>
        /// <returns>Product Details</returns>
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductById(string productId)
        {
            var product = await _productService.GetProductByIdAsync(productId);
            return Ok(product);
        }
        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="product">Product to create</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateProduct(object product)
        {
            var newProduct = await _productService.CreateProductAsync(product);
            return Ok(newProduct);
        }
        /// <summary>
        /// Update an existing product
        /// </summary>
        /// <param name="productId">Id of product to update</param>
        /// <returns></returns>
        [HttpPut("{productId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateProduct(string productId, object modifiedProduct)
        {
            var updatedProduct = await _productService.UpdateProductAsync(productId, modifiedProduct);
            return Ok(updatedProduct);
        }
        /// <summary>
        /// Delete a product from catalog (admin only)
        /// </summary>
        /// <param name="productId">Id of product to delete</param>
        /// <returns></returns>
        [HttpDelete("{productId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProduct(string productId)
        {
            await _productService.DeleteProductAsync(productId);
            return Ok();
        }
        /// <summary>
        /// Search products by keyword, filter, price, etc.
        /// </summary>
        /// <param name="searchCriteria">Search criteria to apply </param>
        /// <returns>List of products</returns>
        [HttpGet("search")]
        public async Task<IActionResult> GetFilteredProducts(object searchCriteria)
        {
            var productsList = await _productService.GetFilteredProductsAsync(searchCriteria);
            return Ok(productsList);
        }
        /// <summary>
        /// Get products under a specific category
        /// </summary>
        /// <param name="categoryId">Id of category to fetch products for </param>
        /// <returns>List of products</returns>
        [HttpGet("category/{categoryId}")]
        public async Task<IActionResult> GetProductsByCategoryId(string categoryId)
        {
            var productList = await _productService.GetProductsByCategoryIdAsync(categoryId);
            return Ok(productList);
        }
        /// <summary>
        /// Retrieve attributes (color, size, etc.) for a specific product
        /// </summary>
        /// <param name="productId">Id of product to fetch attributes for</param>
        /// <returns></returns>
        [HttpGet("{productId}/attributes")]
        public async Task<IActionResult> GetProductAttributesByProductId(string productId)
        {
            var productList = await _productService.GetProductAttributesByProductIdAsync(productId);
            return Ok(productList);
        }
        /// <summary>
        /// Update product attributes (admin-only)
        /// </summary>
        /// <param name="productId">Id of product to update attributes for</param>
        /// <param name="productAttributes">Updated product attribute collection</param>
        /// <returns></returns>
        [HttpPut("{productId}/attributes")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateProductAttributes(string productId, IList<object> productAttributes)
        {
            var updatedProduct = await _productService.UpdateProductAttributesAsync(productId, productAttributes);
            return Ok(updatedProduct);
        }
        /// <summary>
        /// Get available product tags
        /// </summary>
        /// <returns></returns>
        [HttpGet("tags")]
        public async Task<IActionResult> GetAvailableProductTags()
        {
            var tags = await _productService.GetAvailableProductTagsAsync();
            return Ok(tags);
        }
        /// <summary>
        /// List all product brands
        /// </summary>
        /// <returns></returns>
        [HttpGet("brands")]
        public async Task<IActionResult> GetAllProductBrands()
        {
            var brands = await _productService.GetAllProductBrandsAsync();
            return Ok(brands);
        }
        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <returns></returns>
        [HttpGet("health")]
        public async Task<IActionResult> HealthCheck()
        {
            await _productService.HealthCheckAsync();
            return Ok();
        }
    }
}
