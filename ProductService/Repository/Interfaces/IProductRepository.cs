using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<object> CreateProductAsync(object product);
        Task DeleteProductAsync(string productId);
        Task<IList<object>> GetAllProductBrandsAsync();
        Task<IList<object>> GetAvailableProductTagsAsync();
        Task<IList<object>> GetFilteredProductsAsync(object searchCriteria);
        Task<IList<object>> GetPaginatedProductsAsync();
        Task<IList<object>> GetProductAttributesByProductIdAsync(string productId);
        Task<object> GetProductByIdAsync(string productId);
        Task<IList<object>> GetProductsByCategoryIdAsync(string categoryId);
        Task HealthCheckAsync();
        Task<object> UpdateProductAsync(object product, object modifiedProduct);
        Task<IList<object>> UpdateProductAttributesAsync(string productId, IList<object> productAttributes);
    }
}
