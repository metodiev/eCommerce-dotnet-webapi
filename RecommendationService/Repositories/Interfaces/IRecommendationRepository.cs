using System;
using System.Collections.Generic;
using System.Text;

namespace RecommendationService.Repositories.Interfaces
{
    public interface IRecommendationRepository
    {
        Task GetUserProductRecommendationsAsync(string userId);
        Task GetTrendingOrPopularProductRecommendationsAsync(string userId);
        Task GetCategorySpecificRecommendationAsync(string userId, string categoryId);
        Task GetGeneralTrendingProductsRecommendationAsync();
        Task MakeServiceHealthCheckAsync();
    }
}
