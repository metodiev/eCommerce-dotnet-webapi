using AuthService.Repository.Interfaces;
using AuthService.Service_Layer.Interfaces;

namespace AuthService.Service_Layer
{
    internal class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }
        public async Task<bool> AssignRoleToUserAsync(string userId, string roleId)
        {
            return await _authRepository.AssignRoleToUserAsync(userId, roleId);
        }

        public async Task<bool> ChangePasswordAsync(string userId, string oldPassword, string newPassword)
        {
            return await _authRepository.ChangePasswordAsync(userId, oldPassword, newPassword);
        }

        public async Task CreateNewRoleAsync()
        {
             await _authRepository.CreateNewRoleAsync();
        }

        public async Task DeleteRoleAsync(string roleId)
        {
             await _authRepository.DeleteRoleAsync(roleId);
        }

        public async Task<bool> ForgotPasswordAsync(string userId)
        {
            return await _authRepository.ForgotPasswordAsync(userId);
        }

        public async Task GetAllRolesAsync()
        {
           await _authRepository.GetAllRolesAsync();
        }

        public async Task GetRoleByIdAsync(string roleId)
        {
             await _authRepository.GetRoleByIdAsync(roleId);
        }

        public async Task GetSessionAsync(string jwt)
        {
            await _authRepository.GetSessionAsync(jwt);
        }

        public async Task GetUserAssignedRolesAsync(string userId)
        {
             await _authRepository.GetUserAssignedRolesAsync(userId);
        }

        public async Task LoginAsync()
        {
           await _authRepository.LoginAsync();
        }

        public async Task<bool> LogoutAsync(string userId)
        {
            return await _authRepository.LogoutAsync(userId);
        }

        public async Task<string> RefreshTokenAsync(string refreshToken)
        {
            return await _authRepository.RefreshTokenAsync(refreshToken);
        }

        public async Task<bool> RegisterAsync()
        {
            return await _authRepository.RegisterAsync();
        }

        public async Task<bool> ResetPasswordAsync(string userId)
        {
            return await _authRepository.ResetPasswordAsync(userId);
        }

        public async Task UpdateRoleAsync()
        {
             await _authRepository.UpdateRoleAsync();
        }
    }
}
