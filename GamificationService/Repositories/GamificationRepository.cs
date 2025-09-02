using GamificationService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamificationService.Repositories
{
    public class GamificationRepository : IGamificationRepository
    {
        public Task<IList<object>> GetLeaderBoardAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetProgressAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetRewardsStatusesByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetThresholdsAsync()
        {
            throw new NotImplementedException();
        }

        public Task HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> RedeemRewardsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<object> TrackGamificationEventsAsync(object newAction)
        {
            throw new NotImplementedException();
        }
    }
}
