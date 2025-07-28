using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SearchService.Services.Interfaces;

namespace SearchService.Controllers.v1
{
    [Route("api/v1/search")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;
        /// <summary>
        /// Should initialize the SearchService through dependency injection
        /// </summary>
        /// <param name="searchService">Service handling Search-related business logic</param>
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }
        /// <summary>
        /// Search products with query parameters (keywords, filters)
        /// </summary>
        /// <param name="productId">Id of product</param>
        /// <returns></returns>
        [HttpGet("products")]
        public async Task<IActionResult> GetFilteredProducts([FromQuery]IList<string> keywords, [FromQuery]IList<string> filters)
        {
            var products = await _searchService.GetFilteredProductsAsync(keywords, filters);
            return Ok(products);
        }
        /// <summary>
        /// Get detailed product info from search index
        /// </summary>
        /// <param name="productId">Id of product to fetch details for</param>
        /// <returns></returns>
        [HttpGet("products/{productId}")]
        public async Task<IActionResult> GetProductDetailsFromId(int productId)
        {
            var product = await _searchService.GetProductDetailsFromIdAsync(productId);
            return Ok(product);
        }
        /// <summary>
        /// Trigger a full rebuild of the search index
        /// </summary>
        /// <returns></returns>
        [HttpPost("index/rebuild")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RebuildSearchIndex()
        {
            await _searchService.RebuildSearchIndexAsync();
            return Ok();
        }
        /// <summary>
        /// Get search autocomplete suggestions
        /// </summary>
        /// <param name="searchText">Text snippet entered for the search</param>
        /// <returns></returns>
        [HttpGet("suggestions")]
        public async Task<IActionResult> GetSuggestions(string searchText)
        {
            var suggestions = await _searchService.GetSuggestionsAsync(searchText);
            return Ok(suggestions);
        }
        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <returns></returns>
        [HttpGet("health")]
        public async Task<IActionResult> HealthCheck()
        {
            await _searchService.HealthCheckAsync();
            return Ok();
        }
    }
}
