using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PromotionService.Services.Interfaces;

namespace PromotionService.Controllers.v1
{
    [Route("api/v1/promotions")]
    [ApiController]
    [Authorize]
    public class PromotionController : ControllerBase
    {
        private readonly IPromotionService _promotionService;
        /// <summary>
        /// Should initialize the PromotionService through dependency injection
        /// </summary>
        /// <param name="PromotionService">Service handling Promotion-related business logic</param>
        public PromotionController(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }
        /// <summary>
        /// Get a list of active promotions, campaigns, and banners
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetActivePromotions()
        {
            var promotionsList = await _promotionService.GetActivePromotionsAsync();
            return Ok(promotionsList);
        }
        /// <summary>
        /// Get details about a specific promotion or coupon code
        /// </summary>
        /// <param name="promoCode">Promocode to get details for</param>
        /// <returns></returns>
        [HttpGet("{promoCode}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPromoCodeDetails(string promoCode)
        {
            var promoDetails = await _promotionService.GetPromoCodeDetailsAsync(promoCode);
            return Ok(promoDetails);
        }
        /// <summary>
        /// Validate a coupon or promo code against the current cart or user
        /// </summary>
        /// <param name="cart">Cart against which to validate/fetch the coupon</param>
        /// <returns></returns>
        [HttpPost("validate")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> ValidatePromoCode(object cart)
        {
            await _promotionService.ValidatePromoCodeAsync(cart);
            return Ok();
        }
        /// <summary>
        /// Create a new promotion or campaign
        /// </summary>
        /// <param name="promotion">New promotion</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreatePromotion(object promotion)
        {
            var newPromotion = await _promotionService.CreatePromotionAsync(promotion);
            return Ok(newPromotion);
        }
        /// <summary>
        /// Update an existing promotion
        /// </summary>
        /// <param name="promotionId">Id of promotion to update</param>
        /// <returns></returns>
        [HttpPut("{promotionId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdatePromotion(int promotionId, object modifiedPromotion)
        {
            var updatedPromotion = await _promotionService.UpdatePromotionAsync(promotionId, modifiedPromotion);
            return Ok(updatedPromotion);
        }
        /// <summary>
        /// Delete or deactivate a promotion
        /// </summary>
        /// <param name="promotionId">Id of promotion to delete</param>
        /// <returns></returns>
        [HttpDelete("{promotionId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletePromotion(int promotionId)
        {
            await _promotionService.DeletePromotionAsync(promotionId);
            return Ok();
        }
        /// <summary>
        /// Get active or personalized promotions for a user
        /// </summary>
        /// <param name="promotionId">Id of user to fetch</param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetPersonalizedPromotionsForUser(int userId)
        {
            var promotionsList = await _promotionService.GetPersonalizedPromotionsForUserAsync(userId);
            return Ok();
        }
        /// <summary>
        /// Get banner ads and campaign visuals (e.g. homepage banners)
        /// </summary>
        /// <returns></returns>
        [HttpGet("banners")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBannersAndVisuals()
        {
            var banners = await _promotionService.GetBannersAndVisualsAsync();
            return Ok(banners);
        }
        public async Task<IActionResult> HealthCheck()
        {
            return Ok();
        }
    }
}
