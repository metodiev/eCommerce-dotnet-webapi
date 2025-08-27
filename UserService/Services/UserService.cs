using System;
using System.Collections.Generic;
using System.Text;
using UserService.Repository.Interfaces;
using UserService.Services.Interfaces;

namespace UserService.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<object> CreateUserAsync(object value)
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

        public Task<object> UpdateUserPreferencesAsync(int userId, object preferences)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateUserProfileDetailsAsync(int userId, object user)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateUserSettingsAsync(int userId, object settings)
        {
            throw new NotImplementedException();
        }
    }
}
