using PromotionService.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionService.Repository
{
    public class PromotionRepository : IPromotionRepository
    {
        public Task<object> CreatePromotionAsync(object promotion)
        {
            throw new NotImplementedException();
        }

        public Task DeletePromotionAsync(int promotionId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetActivePromotionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetBannersAndVisualsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetPersonalizedPromotionsForUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetPromoCodeDetailsAsync(string promoCode)
        {
            throw new NotImplementedException();
        }

        public Task HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdatePromotionAsync(int promotionId, object modifiedPromotion)
        {
            throw new NotImplementedException();
        }

        public Task ValidatePromoCodeAsync(object cart)
        {
            throw new NotImplementedException();
        }
    }
}
