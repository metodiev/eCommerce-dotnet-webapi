using AnalyticsService.Repositories.Interfaces;
using AnalyticsService.Services.Interfaces;

namespace AnalyticsService.Services
{
    public class AnalyticsService : IAnalyticsService
    {
        private readonly IAnalyticsRepository _analyticsRepository;
        public AnalyticsService(IAnalyticsRepository analyticsRepository)
        {
            _analyticsRepository = analyticsRepository;
        }
        public async Task<List<object>> GetHighLevelKPIsAsync()
        {
            return await _analyticsRepository.GetHighLevelKPIsAsync();
        }

        public async Task<List<object>> GetPreconfiguredDashboardDataAsync(string dashboardId)
        {
            return await _analyticsRepository.GetPreconfiguredDashboardDataAsync(dashboardId);
        }

        public async Task<List<object>> GetSessionEventsAsync(string sessionId)
        {
            return await _analyticsRepository.GetSessionEventsAsync(sessionId);
        }

        public async Task<List<object>> GetUserEventHistoryAsync(string userId)
        {
            return await _analyticsRepository.GetUserEventHistoryAsync(userId);
        }

        public async Task<string> HealthCheckAsync()
        {
            return await _analyticsRepository.HealthCheckAsync();
        }

        public async Task<bool> SendEventsBatchAsync(List<object> trackEvents)
        {
            return await _analyticsRepository.SendEventsBatchAsync(trackEvents);
        }

        public async Task<bool> TrackErrorsAsync()
        {
            return await _analyticsRepository.TrackErrorsAsync();
        }

        public async Task<bool> TrackSingleEventAsync(object trackEvent)
        {
            return await _analyticsRepository.TrackSingleEventAsync(trackEvent);
        }
    }
}
