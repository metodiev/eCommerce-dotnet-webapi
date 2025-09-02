using System;
using System.Collections.Generic;
using System.Text;

namespace GamificationService.Services.Interfaces
{
    public interface IGamificationService
    {
        Task<IList<object>> GetLeaderBoardAsync();
        Task<object> GetProgressAsync(string userId);
        Task<IList<object>> GetRewardsStatusesByUserIdAsync(string userId);
        Task<IList<object>> GetThresholdsAsync();
        Task HealthCheckAsync();
        Task<object> RedeemRewardsAsync(string userId);
        Task<object> TrackGamificationEventsAsync(object newAction);
    }
}
