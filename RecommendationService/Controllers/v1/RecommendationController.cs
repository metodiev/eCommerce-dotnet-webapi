using Microsoft.AspNetCore.Mvc;
using RecommendationService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecommendationService.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RecommendationController : ControllerBase
    {
        private readonly IRecommendationService _recommendationService;
        public RecommendationController(IRecommendationService recommendationService)
        {
            _recommendationService = recommendationService;
        }


        /// <summary>
        /// This endpoint is intended to be used to display a user-specific list of products that the user might be interested in, based on their previous purchase history
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>A List of Product objects</returns>
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserProductRecommendations(string userId)
        {
            await _recommendationService.GetUserProductRecommendationsAsync(userId);
            return Ok();
        }

        /// <summary>
        /// Gets a list of products that are trending, in case there in insufficient data to make a list of user-specific recommendations.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>A List of Product Objects</returns>
        [HttpGet("{userId}/trending")]
        public async Task<IActionResult> GetTrendingOrPopularProductRecommendations(string userId)
        {
            await _recommendationService.GetTrendingOrPopularProductRecommendationsAsync(userId);
            return Ok();
        }

        /// <summary>
        /// Gets a list of products that the user might be interested in, filtered by category (i.e Monitors) 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="categoryId"></param>
        /// <returns>A List of Product Objects</returns>
        [HttpGet("{userId}/categories/{categoryId}")]
        public async Task<IActionResult> GetCategorySpecificRecommendation(string userId, string categoryId)
        {
            await _recommendationService.GetCategorySpecificRecommendationAsync(userId, categoryId);
            return Ok();
        }


        /// <summary>
        /// Gets a general list of currently trending products, based off of purchases or product views.
        /// </summary>
        /// <returns>A List of Product Objects </returns>
        [HttpGet("trending")]
        public async Task<IActionResult> GetGeneralTrendingProductsRecommendation()
        {
            await _recommendationService.GetGeneralTrendingProductsRecommendationAsync();
            return Ok();
        }


        /// <summary>
        /// Makes a health check towards the Recommendation Java service
        /// </summary>
        /// <returns>The status of the Java Service</returns>
        [HttpGet("health")]
        public async Task<IActionResult> MakeServiceHealthCheck()
        {
            await _recommendationService.MakeServiceHealthCheckAsync();
            return Ok();
        }
    }
}
