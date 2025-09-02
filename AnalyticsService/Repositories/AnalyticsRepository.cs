using AnalyticsService.Repositories.Interfaces;

namespace AnalyticsService.Repositories
{
    public class AnalyticsRepository : IAnalyticsRepository
    {
        public Task<List<object>> GetHighLevelKPIsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetPreconfiguredDashboardDataAsync(string dashboardId)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetSessionEventsAsync(string sessionId)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetUserEventHistoryAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SendEventsBatchAsync(List<object> trackEvents)
        {
            throw new NotImplementedException();
        }

        public Task<bool> TrackErrorsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> TrackSingleEventAsync(object trackEvent)
        {
            throw new NotImplementedException();
        }
    }
}
