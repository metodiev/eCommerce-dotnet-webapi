using GamificationService.Repositories.Interfaces;
using GamificationService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamificationService.Services
{
    public class GamificationService : IGamificationService
    {
        private readonly IGamificationRepository _gamificationRepository;
        public GamificationService(IGamificationRepository gamificationRepository)
        {
            _gamificationRepository = gamificationRepository;
        }
        public async Task<IList<object>> GetLeaderBoardAsync()
        {
             return await _gamificationRepository.GetLeaderBoardAsync();
        }

        public async Task<object> GetProgressAsync(string userId)
        {
            return await _gamificationRepository.GetProgressAsync(userId);
        }

        public async Task<IList<object>> GetRewardsStatusesByUserIdAsync(string userId)
        {
            return await _gamificationRepository.GetRewardsStatusesByUserIdAsync(userId);
        }

        public async Task<IList<object>> GetThresholdsAsync()
        {
            return await _gamificationRepository.GetThresholdsAsync();
        }

        public async Task HealthCheckAsync()
        {
            await _gamificationRepository.HealthCheckAsync();
        }

        public async Task<object> RedeemRewardsAsync(string userId)
        {
            return await _gamificationRepository.RedeemRewardsAsync(userId);
        }

        public async Task<object> TrackGamificationEventsAsync(object newAction)
        {
            return await _gamificationRepository.TrackGamificationEventsAsync(newAction);
        }
    }
}
