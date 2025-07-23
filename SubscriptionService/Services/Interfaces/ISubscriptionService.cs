using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionService.Services.Interfaces
{
    public interface ISubscriptionService
    {
        Task<object> CancelSubscriptionByIdAsync(int subscriptionId);
        Task<object> CreateSubscriptionForUserAsync();
        Task<IList<object>> GetAllSubscriptionsForUserAsync(int userId);
        Task<IList<object>> GetAvailableSubscriptionPlansAsync();
        Task<object> GetSubscriptionByIdAsync(int subscriptionId);
        Task HealthCheckAsync();
        Task<object> PauseSubscriptionByIdAsync(int subscriptionId);
        Task<object> ReceivePaymentEventsAsync(object payload);
        Task<object> ResumeSubscriptionByIdAsync(int subscriptionId);
        Task<object> UpgradeSubscriptionAsync(int subscriptionId, object subscription);
    }
}
