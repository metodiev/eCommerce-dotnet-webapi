using SubscriptionService.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionService.Repository
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        public Task<object> CancelSubscriptionByIdAsync(int subscriptionId)
        {
            throw new NotImplementedException();
        }

        public Task<object> CreateSubscriptionForUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllSubscriptionsForUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAvailableSubscriptionPlansAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetSubscriptionByIdAsync(int subscriptionId)
        {
            throw new NotImplementedException();
        }

        public Task HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> PauseSubscriptionByIdAsync(int subscriptionId)
        {
            throw new NotImplementedException();
        }

        public Task<object> ReceivePaymentEventsAsync(object payload)
        {
            throw new NotImplementedException();
        }

        public Task<object> ResumeSubscriptionByIdAsync(int subscriptionId)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpgradeSubscriptionAsync(int subscriptionId, object subscription)
        {
            throw new NotImplementedException();
        }
    }
}
