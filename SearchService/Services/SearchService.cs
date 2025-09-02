using SearchService.Repositories.Interfaces;
using SearchService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchService.Services
{
    public class SearchService : ISearchService
    {
        private readonly ISearchRepository _searchRepository;
        public SearchService(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }
        public async Task<IList<object>> GetFilteredProductsAsync(IList<string> keywords, IList<string> filters)
        {
            return await _searchRepository.GetFilteredProductsAsync(keywords, filters);
        }

        public async Task<object> GetProductDetailsFromIdAsync(string productId)
        {
            return await _searchRepository.GetProductDetailsFromIdAsync(productId);
        }

        public async Task<IList<object>> GetSuggestionsAsync(string searchText)
        {
            return await _searchRepository.GetSuggestionsAsync(searchText);
        }

        public async Task HealthCheckAsync()
        {
            await _searchRepository.HealthCheckAsync();
        }

        public async Task RebuildSearchIndexAsync()
        {
            await _searchRepository.RebuildSearchIndexAsync();
        }
    }
}
