namespace AuthService.Service_Layer.Interfaces
{
    public interface IAuthService
    {
        Task<bool> RegisterAsync();
        Task LoginAsync();
        Task<string> RefreshTokenAsync(string refreshToken);
        Task<bool> LogoutAsync(string userId);
        Task GetSessionAsync(string jwt);
        Task<bool> ForgotPasswordAsync(string userId);
        Task<bool> ResetPasswordAsync(string userId);
        Task<bool> ChangePasswordAsync(string userId, string oldPassword, string newPassword);
        Task GetAllRolesAsync();
        Task GetRoleByIdAsync(string roleId);
        Task CreateNewRoleAsync();
        Task UpdateRoleAsync();
        Task DeleteRoleAsync(string roleId);
        Task GetUserAssignedRolesAsync(string userId);
        Task<bool> AssignRoleToUserAsync(string userId, string roleId);
    }
}
