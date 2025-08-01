using System;
using System.Collections.Generic;
using System.Text;

namespace GamificationService.Repositories.Interfaces
{
    public interface IGamificationRepository
    {
        Task<IList<object>> GetLeaderBoardAsync();
        Task<object> GetProgressAsync(int userId);
        Task<IList<object>> GetRewardsStatusesByUserIdAsync(int userId);
        Task<IList<object>> GetThresholdsAsync();
        Task HealthCheckAsync();
        Task<object> RedeemRewardsAsync(int userId);
        Task<object> TrackGamificationEventsAsync(object newAction);
    }
}
