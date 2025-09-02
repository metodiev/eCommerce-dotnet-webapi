using RecommendationService.Repositories.Interfaces;

namespace RecommendationService.Repositories
{
    public class RecommendationRepository : IRecommendationRepository
    {
        public Task GetCategorySpecificRecommendationAsync(string userId, string categoryId)
        {
            throw new NotImplementedException();
        }

        public Task GetGeneralTrendingProductsRecommendationAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetTrendingOrPopularProductRecommendationsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task GetUserProductRecommendationsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task MakeServiceHealthCheckAsync()
        {
            throw new NotImplementedException();
        }
    }
}
