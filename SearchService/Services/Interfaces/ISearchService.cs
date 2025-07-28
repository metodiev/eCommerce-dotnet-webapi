using System;
using System.Collections.Generic;
using System.Text;

namespace SearchService.Services.Interfaces
{
    public interface ISearchService
    {
        Task<IList<object>> GetFilteredProductsAsync(IList<string> keywords, IList<string> filters);
        Task<object> GetProductDetailsFromIdAsync(int productId);
        Task<IList<object>> GetSuggestionsAsync(string searchText);
        Task HealthCheckAsync();
        Task RebuildSearchIndexAsync();
    }
}
