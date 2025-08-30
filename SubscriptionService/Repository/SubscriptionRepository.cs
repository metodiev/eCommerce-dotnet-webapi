using SubscriptionService.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionService.Repository
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        public Task<object> CancelSubscriptionByIdAsync(string subscriptionId)
        {
            throw new NotImplementedException();
        }

        public Task<object> CreateSubscriptionForUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllSubscriptionsForUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAvailableSubscriptionPlansAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetSubscriptionByIdAsync(string subscriptionId)
        {
            throw new NotImplementedException();
        }

        public Task HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> PauseSubscriptionByIdAsync(string subscriptionId)
        {
            throw new NotImplementedException();
        }

        public Task<object> ReceivePaymentEventsAsync(object payload)
        {
            throw new NotImplementedException();
        }

        public Task<object> ResumeSubscriptionByIdAsync(string subscriptionId)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpgradeSubscriptionAsync(string subscriptionId, object subscription)
        {
            throw new NotImplementedException();
        }
    }
}
