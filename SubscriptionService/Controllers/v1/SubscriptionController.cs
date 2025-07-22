using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SubscriptionService.Services.Interfaces;

namespace SubscriptionService.Controllers.v1
{
    [Route("api/v1/subscriptions")]
    [ApiController]
    [Authorize]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;
        /// <summary>
        /// Should initialize the SubscriptionService through dependency injection
        /// </summary>
        /// <param name="SubscriptionService">Service handling Subscription-related business logic</param>
        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }
        /// <summary>
        /// Create a new subscription plan for a user
        /// </summary>
        /// <param name="subscription">Subscription plan to create</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> CreateSubscriptionForUser(object subscription)
        {
            var newSubscription = await _subscriptionService.CreateSubscriptionForUserAsync();
            return Ok(newSubscription);
        }
        /// <summary>
        /// Get subscription details by ID
        /// </summary>
        /// <param name="subscriptionId">Id of subscription to fetch</param>
        /// <returns>Subscription Details</returns>
        [HttpGet("{subscriptionId}")]
        [Authorize(Roles = "Owner,Admin")]
        public async Task<IActionResult> GetSubscriptionById(int subscriptionId)
        {
            var subscription = await _subscriptionService.GetSubscriptionByIdAsync(subscriptionId);
            return Ok(subscription);
        }
        /// <summary>
        /// Get all subscriptions for a specific user
        /// </summary>
        /// <param name="userId">Id of user to fetch subscriptions for</param>
        /// <returns></returns>
        [HttpGet("user/{userId}")]
        [Authorize(Roles = "Owner,Admin")]
        public async Task<IActionResult> GetAllSubscriptionsForUser(int userId)
        {
            var subscriptions = await _subscriptionService.GetAllSubscriptionsForUserAsync(userId);
            return Ok(subscriptions);
        }
    }
}
