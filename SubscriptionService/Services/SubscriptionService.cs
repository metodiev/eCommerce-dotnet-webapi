using SubscriptionService.Repository.Interfaces;
using SubscriptionService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionService.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository _subscriptionRepository;
        public SubscriptionService(ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
        }
        public async Task<object> CancelSubscriptionByIdAsync(string subscriptionId)
        {
            return await _subscriptionRepository.CancelSubscriptionByIdAsync(subscriptionId);
        }

        public async Task<object> CreateSubscriptionForUserAsync()
        {
            return await _subscriptionRepository.CreateSubscriptionForUserAsync();
        }

        public async Task<IList<object>> GetAllSubscriptionsForUserAsync(string userId)
        {
            return await _subscriptionRepository.GetAllSubscriptionsForUserAsync(userId);
        }

        public async Task<IList<object>> GetAvailableSubscriptionPlansAsync()
        {
            return await _subscriptionRepository.GetAvailableSubscriptionPlansAsync();
        }

        public async Task<object> GetSubscriptionByIdAsync(string subscriptionId)
        {
            return await _subscriptionRepository.GetSubscriptionByIdAsync(subscriptionId);
        }

        public async Task HealthCheckAsync()
        {
            await _subscriptionRepository.HealthCheckAsync();
        }

        public async Task<object> PauseSubscriptionByIdAsync(string subscriptionId)
        {
            return await _subscriptionRepository.PauseSubscriptionByIdAsync(subscriptionId);
        }

        public async Task<object> ReceivePaymentEventsAsync(object payload)
        {
            return await _subscriptionRepository.ReceivePaymentEventsAsync(payload);
        }

        public async Task<object> ResumeSubscriptionByIdAsync(string subscriptionId)
        {
            return await _subscriptionRepository.ResumeSubscriptionByIdAsync(subscriptionId);
        }

        public async Task<object> UpgradeSubscriptionAsync(string subscriptionId, object subscription)
        {
            return await _subscriptionRepository.UpgradeSubscriptionAsync(subscriptionId, subscription);
        }
    }
}
