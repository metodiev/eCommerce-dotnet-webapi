using SearchService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchService.Repositories
{
    public class SearchRepository : ISearchRepository
    {
        public Task<IList<object>> GetFilteredProductsAsync(IList<string> keywords, IList<string> filters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetProductDetailsFromIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetSuggestionsAsync(string searchText)
        {
            throw new NotImplementedException();
        }

        public Task HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task RebuildSearchIndexAsync()
        {
            throw new NotImplementedException();
        }
    }
}
