using ProductService.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Task<object> CreateProductAsync(object product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllProductBrandsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAvailableProductTagsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetFilteredProductsAsync(object searchCriteria)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetPaginatedProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetProductAttributesByProductIdAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetProductByIdAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetProductsByCategoryIdAsync(string categoryId)
        {
            throw new NotImplementedException();
        }

        public Task HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateProductAsync(object product, object modifiedProduct)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> UpdateProductAttributesAsync(string productId, IList<object> productAttributes)
        {
            throw new NotImplementedException();
        }
    }
}
