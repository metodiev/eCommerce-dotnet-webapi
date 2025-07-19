using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionService.Repository.Interfaces
{
    public interface IPromotionRepository
    {
        Task<object> CreatePromotionAsync(object promotion);
        Task DeletePromotionAsync(int promotionId);
        Task<IList<object>> GetActivePromotionsAsync();
        Task<IList<object>> GetBannersAndVisualsAsync();
        Task<IList<object>> GetPersonalizedPromotionsForUserAsync(int userId);
        Task<object> GetPromoCodeDetailsAsync(string promoCode);
        Task HealthCheckAsync();
        Task<object> UpdatePromotionAsync(int promotionId, object modifiedPromotion);
        Task ValidatePromoCodeAsync(object cart);
    }
}
