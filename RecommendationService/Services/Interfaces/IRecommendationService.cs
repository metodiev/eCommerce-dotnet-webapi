using System;
using System.Collections.Generic;
using System.Text;

namespace RecommendationService.Services.Interfaces
{
    public interface IRecommendationService
    {
        Task GetUserProductRecommendationsAsync(string userId);
        Task GetTrendingOrPopularProductRecommendationsAsync(string userId);
        Task GetCategorySpecificRecommendationAsync(string userId, string categoryId);
        Task GetGeneralTrendingProductsRecommendationAsync();
        Task MakeServiceHealthCheckAsync();
    }
}
