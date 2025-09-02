using ConfigService.Repository.Interfaces;
using ConfigService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigService.Services
{
    public class ConfigService : IConfigService
    {
        private readonly IConfigRepository _configRepository;
        public ConfigService(IConfigRepository configRepository)
        {
            _configRepository = configRepository;
        }
        public async Task<object> CreateFeatureFlagAsync(object featureFlag)
        {
            return await _configRepository.CreateFeatureFlagAsync(featureFlag);
        }

        public async Task<object> CreateSystemSettingAsync(object setting)
        {
            return await _configRepository.CreateSystemSettingAsync(setting);
        }

        public async Task DeleteFeatureFlagAsync(string flagId)
        {
            await _configRepository.DeleteFeatureFlagAsync(flagId);
        }

        public async Task DeleteSystemSettingAsync(string settingId)
        {
            await _configRepository.DeleteSystemSettingAsync(settingId);
        }

        public async Task<IList<object>> GetAllFeatureFlagsAsync()
        {
            return await _configRepository.GetAllFeatureFlagsAsync();
        }

        public async Task<IList<object>> GetAllRecentLogsAsync()
        {
            return await _configRepository.GetAllRecentLogsAsync();
        }

        public async Task<IList<object>> GetAllSystemSettingsAsync()
        {
            return await _configRepository.GetAllSystemSettingsAsync();
        }

        public async Task HealthCheckAsync()
        {
            await _configRepository.HealthCheckAsync();
        }

        public async Task<object> UpdateFeatureFlagAsync(string flagId, object featureFlag)
        {
            return await _configRepository.UpdateFeatureFlagAsync(flagId, featureFlag);
        }

        public async Task<object> UpdateSystemSettingAsync(string settingId, object setting)
        {
            return await _configRepository.UpdateSystemSettingAsync(settingId, setting);
        }
    }
}
