using AnalyticsService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AnalyticsService.Controllers.v1
{
    [ApiController]
    [Route("api/v1/analytics")]
    public class AnalyticsController: ControllerBase
    {
        private readonly IAnalyticsService _analyticsService;

        public AnalyticsController(IAnalyticsService analyticsService)
        {
            _analyticsService = analyticsService;
        }

        /// <summary>
        /// Track a single analytics event like a user click, view or action for a product
        /// </summary>
        /// <returns> Confirmation that event is now being tracked </returns>
        [HttpPost("events")]
        public async Task<IActionResult> TrackSingleEvent([FromBody] object trackEvent)
        {
            var result = await _analyticsService.TrackSingleEventAsync(trackEvent);
            return Ok(result);
        }

        /// <summary>
        /// Track multiple analytics events.
        /// </summary>
        /// <returns> Confirmation that events are now being tracked </returns>
        [HttpPost("events/batch")]
        public async Task<IActionResult> SendEventsBatch([FromBody] List<object> trackEvents)
        {
            var result = await _analyticsService.SendEventsBatchAsync(trackEvents);
            return Ok(result);
        }

        /// <summary>
        /// Retrieves a list of high level KPIs for the Admin dashboard, like number of daily users or sales.
        /// </summary>
        /// <returns> A List of KPI/Event objects </returns>
        [HttpGet("kpis")]
        public async Task<IActionResult> GetHighLevelKPIs()
        {
            var result = await _analyticsService.GetHighLevelKPIsAsync();
            return Ok(result);
        }

        /// <summary>
        /// Retrieves the event history for a specific user.
        /// </summary>
        /// <returns>A List of Event objects </returns>
        [HttpGet("events/user/{userId}")]
        public async Task<IActionResult> GetUserEventHistory(string userId)
        {
            var result = await _analyticsService.GetUserEventHistoryAsync(userId);
            return Ok(result);
        }

        /// <summary>
        /// Retrieves all events tied to the session's device/browser
        /// </summary>
        /// <returns>A List of Event objects? </returns>
        [HttpGet("event/session/{sessionId}")]
        public async Task<IActionResult> GetSessionEvents(string sessionId)
        {
            var result = await _analyticsService.GetSessionEventsAsync(sessionId);
            return Ok(result);
        }

        /// <summary>
        /// Retrieves the preconfigured dashboard data
        /// </summary>
        /// <returns>A List of objects? </returns>
        [HttpGet("dashboard/{dashboardId}")]
        public async Task<IActionResult> GetPreconfiguredDashboardData(string dashboardId)
        {
            var result = await _analyticsService.GetPreconfiguredDashboardDataAsync(dashboardId);
            return Ok(result);
        }


        /// <summary>
        /// Track app-level or front-end errors.
        /// </summary>
        /// <returns> Confirmation that errors are now being tracked </returns>
        [HttpPost("errors")]
        public async Task<IActionResult> TrackErrors()
        {
            var result = await _analyticsService.TrackErrorsAsync();
            return Ok(result);
        }

        /// <summary>
        /// Standard health check endpoint
        /// </summary>
        /// <returns> The result of the health check in string format </returns>
        [HttpGet("health")]
        public async Task<IActionResult> HealthCheck()
        {
            var result = await _analyticsService.HealthCheckAsync();
            return Ok(result);
        }
    }
}
