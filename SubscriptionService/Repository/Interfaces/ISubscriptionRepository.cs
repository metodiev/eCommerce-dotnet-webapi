using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionService.Repository.Interfaces
{
    public interface ISubscriptionRepository
    {
        Task<object> CancelSubscriptionByIdAsync(string subscriptionId);
        Task<object> CreateSubscriptionForUserAsync();
        Task<IList<object>> GetAllSubscriptionsForUserAsync(string userId);
        Task<IList<object>> GetAvailableSubscriptionPlansAsync();
        Task<object> GetSubscriptionByIdAsync(string subscriptionId);
        Task HealthCheckAsync();
        Task<object> PauseSubscriptionByIdAsync(string subscriptionId);
        Task<object> ReceivePaymentEventsAsync(object payload);
        Task<object> ResumeSubscriptionByIdAsync(string subscriptionId);
        Task<object> UpgradeSubscriptionAsync(string subscriptionId, object subscription);
    }
}
