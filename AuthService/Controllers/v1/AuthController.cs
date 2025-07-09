using AuthService.Service_Layer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers.v1
{
    [ApiController]
    [Route("v1/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        /// <summary>
        /// The endpoint used by the frontend to allow users to register.
        /// </summary>
        /// <returns>A Status(boolean) signifying if the register was successful</returns>
        [HttpPost("register")]
        public IActionResult Register()
        {
            var result = _authService.RegisterAsync();
            return Ok(result);
        }


        /// <summary>
        /// The endpoint that allows users to login using the already existing account credentials
        /// </summary>
        /// <returns>User object? </returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            await _authService.LoginAsync();
            return Ok();
        }

        /// <summary>
        /// Refreshed the user's JWT using a predetermined refresh token.
        /// </summary>
        /// <returns>New JWT(string) </returns>
        [HttpPost("refresh")]
        public async Task<IActionResult> RefreshToken(string refreshToken)
        {
            var result = await _authService.RefreshTokenAsync(refreshToken);
            return Ok();
        }

        /// <summary>
        /// Invalidates the user's JWT
        /// </summary>
        /// <returns>Status(boolean) signifying if user's JWT was properly invalidated</returns>
        [HttpPost("logout")]
        public async Task<IActionResult> Logout(string userId)
        {
            await _authService.LogoutAsync(userId);
            return Ok();
        }

        /// <summary>
        /// Get current session info from JWT
        /// </summary>
        /// <returns>Session object</returns>
        [HttpGet("session")]
        public async Task<IActionResult> GetSession([FromBody] string jwt)
        {
            await _authService.GetSessionAsync(jwt);
            return Ok();
        }

        /// <summary>
        /// Allows users to receive a "reset password" link by validating their email
        /// </summary>
        /// <returns>Status(boolean) signifying if email was sent </returns>
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(string userId)
        {
            await _authService.ForgotPasswordAsync(userId);
            return Ok();
        }

        /// <summary>
        /// Allows users to reset their password using a specially generated password reset link
        /// </summary>
        /// <returns> Status(boolean) signifying if the password was successfully reset </returns>
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(string userId)
        {
            await _authService.ResetPasswordAsync(userId);
            return Ok();
        }

        /// <summary>
        /// Allows users to change their password after validating and logging in by providing new and old password.
        /// </summary>
        /// <returns>Status(boolean) signifying if the password was successfully changed </returns>
        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword(string userId, string oldPassword, string newPassword)
        {
            await _authService.ChangePasswordAsync(userId,oldPassword,newPassword);
            return Ok();
        }

        /// <summary>
        /// An endpoint which returns all existing roles
        /// </summary>
        /// <returns> All roles within the database(provided by Java service) </returns>
        [HttpGet("roles")]
        public async Task<IActionResult> GetAllRoles()
        {
            await _authService.GetAllRolesAsync();
            return Ok();
        }

        /// <summary>
        /// An endpoint which returns a specific role using a provided roleId
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns>A Role object </returns>
        [HttpGet("roles/{id}")]
        public async Task<IActionResult> GetRoleById(string roleId)
        {
            await _authService.GetRoleByIdAsync(roleId);
            return Ok();
        }

        /// <summary>
        /// Allows admin users to create new roles
        /// </summary>
        /// <returns>Newly generated Role object</returns>
        [HttpPost("roles")]
        //[Authorization("admin")] -- will add after deciding auth logic
        public async Task<IActionResult> CreateNewRole()
        {
            await _authService.CreateNewRoleAsync();
            return Ok();
        }

        /// <summary>
        /// Allows admin level users to update existing roles
        /// </summary>
        /// <returns>Newly updated Role object</returns>
        [HttpPut("roles/{id}")]
        //[Authorization("admin")] -- will add after deciding auth logic
        public async Task<IActionResult> UpdateRole()
        {
            await _authService.UpdateRoleAsync();
            return Ok();
        }

        /// <summary>
        /// Allows admin level users to delete eligible roles
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns>Status(boolean) signifying whether role was deleted </returns>
        [HttpDelete("roles/{id}")]
        //[Authorization("admin")] -- will add after deciding auth logic
        public async Task<IActionResult> DeleteRole(string roleId)
        {
            await _authService.DeleteRoleAsync(roleId);
            return Ok();
        }

        /// <summary>
        /// Allows admin level users to retrieve the roles assigned to a specific user by providing that user's Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>A List<RoleObject> of the user's assigned roles </returns>
        [HttpGet("users/{userId}/roles")]
        //[Authorization("admin")] -- will add after deciding auth logic
        public async Task<IActionResult> GetUserAssignedRoles(string userId)
        {
            await _authService.GetUserAssignedRolesAsync(userId);
            return Ok();
        }

        /// <summary>
        /// Allows admin level users to assign new roles to existing eligible users
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Status(boolean) signifying whether user was assigned the role</returns>
        [HttpPut("users/{userId}/roles")]
        //[Authorization("admin")] -- will add after deciding auth logic
        public async Task<IActionResult> AssignRoleToUser(string userId, string roleId)
        {
            await _authService.AssignRoleToUserAsync(userId, roleId);
            return Ok();
        }
    }
}
