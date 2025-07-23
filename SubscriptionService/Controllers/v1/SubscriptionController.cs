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
        /// <summary>
        /// Cancel a subscription (e.g. end of billing cycle)
        /// </summary>
        /// <param name="subscriptionId">Id of subscription to cancel</param>
        /// <returns></returns>
        [HttpPut("{subscriptionId}/cancel")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> CancelSubscriptionById(int subscriptionId)
        {
            var canceledSubscription = await _subscriptionService.CancelSubscriptionByIdAsync(subscriptionId);
            return Ok(canceledSubscription);
        }
        /// <summary>
        /// Pause a subscription temporarily
        /// </summary>
        /// <param name="subscriptionId">Id of subscription to pause</param>
        /// <returns></returns>
        [HttpPut("{subscriptionId}/pause")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> PauseSubscriptionById(int subscriptionId)
        {
            var pausedSubscription = await _subscriptionService.PauseSubscriptionByIdAsync(subscriptionId);
            return Ok(pausedSubscription);
        }
        /// <summary>
        /// Resume a paused subscription
        /// </summary>
        /// <param name="subscriptionId">Id of subscription to resume</param>
        /// <returns></returns>
        [HttpPut("{subscriptionId}/resume")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> ResumeSubscriptionById(int subscriptionId)
        {
            var resumedSubscription = await _subscriptionService.ResumeSubscriptionByIdAsync(subscriptionId);
            return Ok(resumedSubscription);
        }
        /// <summary>
        /// Upgrade or change a user’s subscription plan
        /// </summary>
        /// <param name="subscriptionId">Id of subscription to upgrade</param>
        /// <param name="subscription">Updated subscription object</param>
        /// <returns></returns>
        [HttpPut("{subscriptionId}/upgrade")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> UpgradeSubscription(int subscriptionId, object subscription)
        {
            var upgradedSubscription = await _subscriptionService.UpgradeSubscriptionAsync(subscriptionId, subscription);
            return Ok(upgradedSubscription);
        }
        /// <summary>
        /// Get a list of available subscription plans
        /// </summary>
        /// <returns></returns>
        [HttpGet("plans")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAvailableSubscriptionPlans()
        {
            var subscriptionPlanList = await _subscriptionService.GetAvailableSubscriptionPlansAsync();
            return Ok(subscriptionPlanList);
        }
        /// <summary>
        /// Receive payment events from payment gateway (e.g., Stripe)
        /// </summary>
        /// <returns></returns>
        [HttpPost("webhook/payment")]
        public async Task<IActionResult> ReceivePaymentEvents(object payload)
        {
            var paymentEvents = await _subscriptionService.ReceivePaymentEventsAsync(payload);
            return Ok(paymentEvents);
        }
        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <returns></returns>
        [HttpGet("health")]
        public async Task<IActionResult> HealthCheck()
        {
            await _subscriptionService.HealthCheckAsync();
            return Ok();
        }
    }
}
