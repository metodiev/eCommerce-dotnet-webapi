using ProductService.Repository.Interfaces;
using ProductService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<object> CreateProductAsync(object product)
        {
            return await _productRepository.CreateProductAsync(product);
        }

        public async Task DeleteProductAsync(string productId)
        {
            await _productRepository.DeleteProductAsync(productId);
        }

        public async Task<IList<object>> GetAllProductBrandsAsync()
        {
            return await _productRepository.GetAllProductBrandsAsync();
        }

        public async Task<IList<object>> GetAvailableProductTagsAsync()
        {
            return await _productRepository.GetAvailableProductTagsAsync();
        }

        public async Task<IList<object>> GetFilteredProductsAsync(object searchCriteria)
        {
            return await _productRepository.GetFilteredProductsAsync(searchCriteria);
        }

        public async Task<IList<object>> GetPaginatedProductsAsync()
        {
            return await _productRepository.GetPaginatedProductsAsync();
        }

        public async Task<IList<object>> GetProductAttributesByProductIdAsync(string productId)
        {
            return await _productRepository.GetProductAttributesByProductIdAsync(productId);
        }

        public async Task<object> GetProductByIdAsync(string productId)
        {
            return await _productRepository.GetProductByIdAsync(productId);
        }

        public async Task<IList<object>> GetProductsByCategoryIdAsync(string categoryId)
        {
            return await _productRepository.GetProductsByCategoryIdAsync(categoryId);
        }

        public async Task HealthCheckAsync()
        {
            await _productRepository.HealthCheckAsync();
        }

        public async Task<object> UpdateProductAsync(object product, object modifiedProduct)
        {
            return await _productRepository.UpdateProductAsync(product, modifiedProduct);
        }

        public async Task<IList<object>> UpdateProductAttributesAsync(string productId, IList<object> productAttributes)
        {
            return await _productRepository.UpdateProductAttributesAsync(productId, productAttributes);
        }
    }
}
