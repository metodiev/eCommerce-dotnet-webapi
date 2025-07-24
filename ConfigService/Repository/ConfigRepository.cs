using ConfigService.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigService.Repository
{
    public class ConfigRepository : IConfigRepository
    {
        public Task<object> CreateFeatureFlagAsync(object featureFlag)
        {
            throw new NotImplementedException();
        }

        public Task<object> CreateSystemSettingAsync(object setting)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFeatureFlagAsync(int flagId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSystemSettingAsync(int settingId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllFeatureFlagsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllRecentLogsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllSystemSettingsAsync()
        {
            throw new NotImplementedException();
        }

        public Task HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateFeatureFlagAsync(int flagId, object featureFlag)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateSystemSettingAsync(int settingId, object setting)
        {
            throw new NotImplementedException();
        }
    }
}
