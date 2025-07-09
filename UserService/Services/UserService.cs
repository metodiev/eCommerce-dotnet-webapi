using System;
using System.Collections.Generic;
using System.Text;
using UserService.Services.Interfaces;

namespace UserService.Services
{
    public class UserService : IUserService
    {
        public Task CreateUserAsync(object value)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetLoyaltyDataByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetPreferencesByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetUserActivityByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetUserByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetUserSettingsByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserPreferencesAsync(int userId, object preferences)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserProfileDetailsAsync(int userId, object user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserSettingsAsync(int userId, object settings)
        {
            throw new NotImplementedException();
        }
    }
}
