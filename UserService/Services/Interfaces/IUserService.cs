using System;
using System.Collections.Generic;
using System.Text;

namespace UserService.Services.Interfaces
{
    public interface IUserService
    {
        public Task CreateUserAsync(object value);
        public Task DeleteUserAsync(int userId);
        public Task<IList<object>> GetAllUsersAsync();
        public Task<IList<object>> GetLoyaltyDataByUserIdAsync(int userId);
        public Task<IList<object>> GetPreferencesByUserIdAsync(int userId);
        public Task<IList<object>> GetUserActivityByUserIdAsync(int userId);
        public Task<object> GetUserByIdAsync(int userId);
        public Task<IList<object>> GetUserSettingsByUserIdAsync(int userId);
        public Task UpdateUserPreferencesAsync(int userId, object preferences);
        public Task UpdateUserProfileDetailsAsync(int userId, object user);
        public Task UpdateUserSettingsAsync(int userId, object settings);
    }
}
