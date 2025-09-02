using System;
using System.Collections.Generic;
using System.Text;

namespace GamificationService.Repositories.Interfaces
{
    public interface IGamificationRepository
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
