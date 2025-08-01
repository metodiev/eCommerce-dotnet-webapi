using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GamificationService.Services.Interfaces;

namespace GamificationService.Controllers.v1
{
    [Route("api/v1/gamification")]
    [ApiController]
    [Authorize(Roles = "User")]
    public class GamificationController : ControllerBase
    {
        private readonly IGamificationService _gamificationService;
        /// <summary>
        /// Should initialize the GamificationService through dependency injection
        /// </summary>
        /// <param name="gamificationService">Service handling Gamification-related business logic</param>
        public GamificationController(IGamificationService gamificationService)
        {
            _gamificationService = gamificationService;
        }
        /// <summary>
        /// Get rewards, badges, and levels earned by a user
        /// </summary>
        /// <param name="userId">Id of user to get reward status for</param>
        /// <returns></returns>
        [HttpGet("users/{userId}/rewards")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> GetRewardsStatusesByUserId(int userId)
        {
            var rewardsStatus = await _gamificationService.GetRewardsStatusesByUserIdAsync(userId);
            return Ok(rewardsStatus);
        }
        /// <summary>
        /// Get gamification status/details by gamification ID
        /// </summary>
        /// <param name="userId">Id of user to redeem rewards for</param>
        /// <returns></returns>
        [HttpPost("users/{userId}/rewards/redeem")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> RedeemRewards(int userId)
        {
            var redeemedReward = await _gamificationService.RedeemRewardsAsync(userId);
            return Ok(redeemedReward);
        }
        /// <summary>
        /// Get current leaderboard rankings
        /// </summary>
        /// <returns></returns>
        [HttpGet("leaderboard")]
        [AllowAnonymous]
        public async Task<IActionResult> GetLeaderBoard()
        {
            var leaderboardList = await _gamificationService.GetLeaderBoardAsync();
            return Ok(leaderboardList);
        }
        /// <summary>
        /// Get available levels and XP thresholds
        /// </summary>
        /// <returns></returns>
        [HttpGet("levels")]
        [AllowAnonymous]
        public async Task<IActionResult> GetThresholds()
        {
            var thresholds = await _gamificationService.GetThresholdsAsync();
            return Ok(thresholds);
        }
        /// <summary>
        /// Track gamification events (e.g., actions that earn points)
        /// </summary>
        /// <param name="newAction">New event earning points and such</param>
        /// <returns></returns>
        [HttpPost("validate")]
        [Authorize]
        public async Task<IActionResult> TrackGamificationEvents(object newAction)
        {
            //new points ledger entry created by the new activity
            var ledgerStatus = await _gamificationService.TrackGamificationEventsAsync(newAction);
            return Ok(ledgerStatus);
        }
        /// <summary>
        /// Get progress toward next level or badge
        /// </summary>
        /// <param name="userId">Id of User to fetch progress for</param>
        /// <returns></returns>
        [HttpGet("users/{userId}/progress")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> GetProgress(int userId)
        {
            var progress = await _gamificationService.GetProgressAsync(userId);
            return Ok(progress);
        }
        /// <summary>
        /// Health check for the GamificationService
        /// </summary>
        /// <returns></returns>
        [HttpGet("health")]
        [AllowAnonymous]
        public async Task<IActionResult> HealthCheck()
        {
            await _gamificationService.HealthCheckAsync();
            return Ok();
        }
    }
}
