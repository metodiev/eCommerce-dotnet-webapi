using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigService.Services.Interfaces
{
    public interface IConfigService
    {
        Task<object> CreateFeatureFlagAsync(object featureFlag);
        Task<object> CreateSystemSettingAsync(object setting);
        Task DeleteFeatureFlagAsync(string flagId);
        Task DeleteSystemSettingAsync(string settingId);
        Task<IList<object>> GetAllFeatureFlagsAsync();
        Task<IList<object>> GetAllRecentLogsAsync();
        Task<IList<object>> GetAllSystemSettingsAsync();
        Task HealthCheckAsync();
        Task<object> UpdateFeatureFlagAsync(string flagId, object featureFlag);
        Task<object> UpdateSystemSettingAsync(string settingId, object setting);
    }
}
