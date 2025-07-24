using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigService.Services.Interfaces
{
    public interface IConfigService
    {
        Task<object> CreateFeatureFlagAsync(object featureFlag);
        Task<object> CreateSystemSettingAsync(object setting);
        Task DeleteFeatureFlagAsync(int flagId);
        Task DeleteSystemSettingAsync(int settingId);
        Task<IList<object>> GetAllFeatureFlagsAsync();
        Task<IList<object>> GetAllRecentLogsAsync();
        Task<IList<object>> GetAllSystemSettingsAsync();
        Task HealthCheckAsync();
        Task<object> UpdateFeatureFlagAsync(int flagId, object featureFlag);
        Task<object> UpdateSystemSettingAsync(int settingId, object setting);
    }
}
