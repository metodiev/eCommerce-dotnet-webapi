using AuthService.Repository.Interfaces;

namespace AuthService.Repository
{
    internal class AuthRepository : IAuthRepository
    {
        public Task<bool> AssignRoleToUserAsync(string userId, string roleId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ChangePasswordAsync(string userId, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateNewRoleAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRoleAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ForgotPasswordAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetAllRolesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetRoleByIdAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetSessionAsync(string jwt)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetUserAssignedRolesAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> LoginAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> LogoutAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> RefreshTokenAsync(string refreshToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResetPasswordAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRoleAsync()
        {
            throw new NotImplementedException();
        }
    }
}
