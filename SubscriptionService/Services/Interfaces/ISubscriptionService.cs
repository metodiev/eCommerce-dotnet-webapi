using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionService.Services.Interfaces
{
    public interface ISubscriptionService
    {
        Task<object> CreateSubscriptionForUserAsync();
        Task<IList<object>> GetAllSubscriptionsForUserAsync(int userId);
        Task<object> GetSubscriptionByIdAsync(int subscriptionId);
    }
}
