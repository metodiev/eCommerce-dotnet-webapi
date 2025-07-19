using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Services.Interfaces
{
    public interface IProductService
    {
        Task<object> CreateProductAsync(object product);
        Task DeleteProductAsync(int productId);
        Task<IList<object>> GetFilteredProductsAsync(object searchCriteria);
        Task<IList<object>> GetPaginatedProductsAsync();
        Task<IList<object>> GetProductAttributesByProductIdAsync(int productId);
        Task<object> GetProductByIdAsync(int productId);
        Task<IList<object>> GetProductsByCategoryIdAsync(int categoryId);
        Task HealthCheckAsync();
        Task<object> UpdateProductAsync(object product, object modifiedProduct);
        Task<IList<object>> UpdateProductAttributesAsync(int productId, IList<object> productAttributes);
    }
}
