namespace AuthService.Repository.Interfaces
{
    public interface IAuthRepository
    {
        Task<bool> RegisterAsync();
        Task<string> LoginAsync();
        Task<string> RefreshTokenAsync(string refreshToken);
        Task<bool> LogoutAsync(string userId);
        Task<object> GetSessionAsync(string jwt);
        Task<bool> ForgotPasswordAsync(string userId);
        Task<bool> ResetPasswordAsync(string userId);
        Task<bool> ChangePasswordAsync(string userId, string oldPassword, string newPassword);
        Task<List<object>> GetAllRolesAsync();
        Task<object> GetRoleByIdAsync(string roleId);
        Task<bool> CreateNewRoleAsync();
        Task<bool> UpdateRoleAsync();
        Task<bool> DeleteRoleAsync(string roleId);
        Task<List<object>> GetUserAssignedRolesAsync(string userId);
        Task<bool> AssignRoleToUserAsync(string userId, string roleId);
    }
}
