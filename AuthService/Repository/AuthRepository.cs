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

        public Task CreateNewRoleAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteRoleAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ForgotPasswordAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task GetAllRolesAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetRoleByIdAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public Task GetSessionAsync(string jwt)
        {
            throw new NotImplementedException();
        }

        public Task GetUserAssignedRolesAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task LoginAsync()
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

        public Task UpdateRoleAsync()
        {
            throw new NotImplementedException();
        }
    }
}
