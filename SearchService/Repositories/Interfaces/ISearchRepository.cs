using System;
using System.Collections.Generic;
using System.Text;

namespace SearchService.Repositories.Interfaces
{
    public interface ISearchRepository
    {
        Task<IList<object>> GetFilteredProductsAsync(IList<string> keywords, IList<string> filters);
        Task<object> GetProductDetailsFromIdAsync(string productId);
        Task<IList<object>> GetSuggestionsAsync(string searchText);
        Task HealthCheckAsync();
        Task RebuildSearchIndexAsync();
    }
}
