using PromotionService.Repository.Interfaces;
using PromotionService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionService.Services
{
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository _promotionRepository;
        public PromotionService(IPromotionRepository promotionRepository)
        {
            _promotionRepository = promotionRepository;
        }
        public async Task<object> CreatePromotionAsync(object promotion)
        {
            return await _promotionRepository.CreatePromotionAsync(promotion);
        }

        public async Task DeletePromotionAsync(int promotionId)
        {
            await _promotionRepository.DeletePromotionAsync(promotionId);
        }

        public async Task<IList<object>> GetActivePromotionsAsync()
        {
            return await _promotionRepository.GetActivePromotionsAsync();
        }

        public async Task<IList<object>> GetBannersAndVisualsAsync()
        {
            return await _promotionRepository.GetBannersAndVisualsAsync();
        }

        public async Task<IList<object>> GetPersonalizedPromotionsForUserAsync(int userId)
        {
            return await _promotionRepository.GetPersonalizedPromotionsForUserAsync(userId);
        }

        public async Task<object> GetPromoCodeDetailsAsync(string promoCode)
        {
            return await _promotionRepository.GetPromoCodeDetailsAsync(promoCode);
        }

        public async Task HealthCheckAsync()
        {
            await _promotionRepository.HealthCheckAsync();
        }

        public async Task<object> UpdatePromotionAsync(int promotionId, object modifiedPromotion)
        {
            return await _promotionRepository.UpdatePromotionAsync(promotionId, modifiedPromotion);
        }

        public async Task ValidatePromoCodeAsync(object cart)
        {
            await _promotionRepository.ValidatePromoCodeAsync(cart);
        }
    }
}
