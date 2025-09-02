using RecommendationService.Repositories.Interfaces;
using RecommendationService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecommendationService.Services
{
    public class RecommendationService : IRecommendationService
    {
        private readonly IRecommendationRepository _recommendationRepository;
        public RecommendationService(IRecommendationRepository recommendationRepository)
        {
            _recommendationRepository = recommendationRepository;
        }

        public async Task GetCategorySpecificRecommendationAsync(string userId, string categoryId)
        {
            await _recommendationRepository.GetCategorySpecificRecommendationAsync(userId, categoryId);
        }

        public async Task GetGeneralTrendingProductsRecommendationAsync()
        {
            await _recommendationRepository.GetGeneralTrendingProductsRecommendationAsync();
        }

        public async Task GetTrendingOrPopularProductRecommendationsAsync(string userId)
        {
            await _recommendationRepository.GetTrendingOrPopularProductRecommendationsAsync(userId);
        }

        public async Task GetUserProductRecommendationsAsync(string userId)
        {
            await _recommendationRepository.GetUserProductRecommendationsAsync(userId);
        }

        public async Task MakeServiceHealthCheckAsync()
        {
            await _recommendationRepository.MakeServiceHealthCheckAsync();
        }
    }
}
