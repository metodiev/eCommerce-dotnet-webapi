using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ConfigService.Services.Interfaces;

namespace ConfigService.Controllers.v1
{
    [Route("api/v1/config")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class ConfigController : ControllerBase
    {
        private readonly IConfigService _configService;
        /// <summary>
        /// Should initialize the ConfigService through dependency injection
        /// </summary>
        /// <param name="ConfigService">Service handling Config-related business logic</param>
        public ConfigController(IConfigService configService)
        {
            _configService = configService;
        }
        /// <summary>
        /// Get all feature flags
        /// </summary>
        /// <returns></returns>
        [HttpGet("feature-flags")]
        public async Task<IActionResult> GetAllFeatureFlags()
        {
            var featureFlags = await _configService.GetAllFeatureFlagsAsync();
            return Ok(featureFlags);
        }
        /// <summary>
        /// Get all system settings
        /// </summary>
        /// <returns>Config Settings</returns>
        [HttpGet("settings")]
        public async Task<IActionResult> GetAllSystemSettings()
        {
            var settings = await _configService.GetAllSystemSettingsAsync();
            return Ok(settings);
        }
        /// <summary>
        /// Get recent system logs
        /// </summary>
        /// <returns>Config Settings</returns>
        [HttpGet("logs")]
        public async Task<IActionResult> GetAllRecentLogs()
        {
            var logs = await _configService.GetAllRecentLogsAsync();
            return Ok(logs);
        }
        /// <summary>
        /// Create a feature flag
        /// </summary>
        /// <param name="featureFlag">Feature flag object for creation</param>
        /// <returns></returns>
        [HttpPost("feature-flags")]
        public async Task<IActionResult> CreateFeatureFlag(object featureFlag)
        {
            var newFeatureFlag = await _configService.CreateFeatureFlagAsync(featureFlag);
            return Ok(newFeatureFlag);
        }
        /// <summary>
        /// Update a feature flag
        /// </summary>
        /// <param name="flagId">Id of flag to update</param>
        /// <param name="featureFlag">Modified feature flag object</param>
        /// <returns></returns>
        [HttpPut("feature-flags/{flagId}")]
        public async Task<IActionResult> UpdateFeatureFlag(int flagId, object featureFlag)
        {
            var modifiedFeatureFlag = await _configService.UpdateFeatureFlagAsync(flagId, featureFlag);
            return Ok(modifiedFeatureFlag);
        }
        /// <summary>
        /// Delete a feature flag
        /// </summary>
        /// <param name="flagId">Id of flag to delete</param>
        /// <returns></returns>
        [HttpDelete("feature-flags/{flagId}")]
        public async Task<IActionResult> DeleteFeatureFlag(int flagId)
        {
            await _configService.DeleteFeatureFlagAsync(flagId);
            return Ok();
        }
        /// <summary>
        /// Create a system setting
        /// </summary>
        /// <param name="setting">System setting object for creation</param>
        /// <returns></returns>
        [HttpPost("settings")]
        public async Task<IActionResult> CreateSystemSetting(object setting)
        {
            var newSetting = await _configService.CreateSystemSettingAsync(setting);
            return Ok(newSetting);
        }
        /// <summary>
        /// Update a system setting
        /// </summary>
        /// <param name="settingId">Id of setting to update</param>
        /// <param name="setting">Modified setting object</param>
        /// <returns></returns>
        [HttpPut("settings/{settingId}")]
        public async Task<IActionResult> UpdateSystemSetting(int settingId, object setting)
        {
            var modifiedSystemSetting = await _configService.UpdateSystemSettingAsync(settingId, setting);
            return Ok(modifiedSystemSetting);
        }
        /// <summary>
        /// Delete a system setting
        /// </summary>
        /// <param name="settingId">Id of setting to delete</param>
        /// <returns></returns>
        [HttpDelete("settings/{settingId}")]
        public async Task<IActionResult> DeleteSystemSetting(int settingId)
        {
            await _configService.DeleteSystemSettingAsync(settingId);
            return Ok();
        }
        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <returns></returns>
        [HttpGet("health")]
        [AllowAnonymous]
        public async Task<IActionResult> HealthCheck()
        {
            await _configService.HealthCheckAsync();
            return Ok();
        }
    }
}
