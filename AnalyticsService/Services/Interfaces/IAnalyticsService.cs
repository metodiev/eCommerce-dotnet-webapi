namespace AnalyticsService.Services.Interfaces
{
    public interface IAnalyticsService
    {
        Task<bool> TrackSingleEventAsync(object trackEvent);
        Task<bool> SendEventsBatchAsync(List<object> trackEvents);
        Task<List<object>> GetHighLevelKPIsAsync();
        Task<List<object>> GetUserEventHistoryAsync(string userId);
        Task<List<object>> GetSessionEventsAsync(string sessionId);
        Task<List<object>> GetPreconfiguredDashboardDataAsync(string dashboardId);
        Task<bool> TrackErrorsAsync();
        Task<string> HealthCheckAsync();
    }
}
