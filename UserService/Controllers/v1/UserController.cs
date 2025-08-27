using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserService.Services.Interfaces;

namespace UserService.Controllers.v1
{
    [Route("api/v1/users")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        /// <summary>
        /// Should initialize the UserService through dependency injection
        /// </summary>
        /// <param name="userService">Service handling User-related business logic</param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        /// <summary>
        /// List all users (admin only).
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        /// <summary>
        /// Create a new user profile (admin or internal use)
        /// </summary>
        /// <param name="value">User to create</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Admin,Internal")]
        public async Task<IActionResult> CreateUser([FromBody] object user)
        {
            var newUser = await _userService.CreateUserAsync(user);
            return Ok(newUser);
        }

        /// <summary>
        /// Update the profile details of a user
        /// </summary>
        /// <param name="userId">Id of user to update</param>
        /// <param name="user">Updated user</param>
        /// <returns>Newly updated user from database</returns>
        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateUserProfileDetails(int userId, [FromBody] object user)
        {
            var updatedProfile = await _userService.UpdateUserProfileDetailsAsync(userId, user);
            return Ok(updatedProfile);
        }
        /// <summary>
        /// Update the user's preferences
        /// </summary>
        /// <param name="userId">Id of user to update</param>
        /// <param name="preferences">Updated user preferences</param>
        /// <returns>Newly updated user preferences from database</returns>
        [HttpPut("{userId}/preferences")]
        public async Task<IActionResult> UpdateUserPreferences(int userId, [FromBody] object preferences)
        {
            var updatedPreferences = await _userService.UpdateUserPreferencesAsync(userId, preferences);
            return Ok(updatedPreferences);
        }
        /// <summary>
        /// Updates user settings
        /// </summary>
        /// <param name="userId">Id of user to update</param>
        /// <param name="settings">Updated user preferences</param>
        /// <returns>Newly updated user settings from database</returns>
        [HttpPut("{userId}/settings")]
        public async Task<IActionResult> UpdateUserSettings(int userId, [FromBody] object settings)
        {
            var updatedSettings = await _userService.UpdateUserSettingsAsync(userId, settings);
            return Ok(updatedSettings);
        }

        /// <summary>
        /// Deletes a user account
        /// </summary>
        /// <param name="userId">Id of user to delete</param>
        /// <returns></returns>
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            await _userService.DeleteUserAsync(userId);
            return Ok();
        }
        /// <summary>
        /// Retrieve the profile information for a given user
        /// </summary>
        /// <param name="userId">Id of user to fetch</param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserById(int userId)
        {
            var user = await _userService.GetUserByIdAsync(userId);
            return Ok(user);
        }
        /// <summary>
        /// Get the user's preferences
        /// </summary>
        /// <param name="userId">Id of user to fetch</param>
        /// <returns></returns>
        [HttpGet("{userId}/preferences")]
        public async Task<IActionResult> GetPreferencesByUserId(int userId)
        {
            var preferences = await _userService.GetPreferencesByUserIdAsync(userId);
            return Ok();
        }
        /// <summary>
        /// Retrieve loyalty points, tiers, and status
        /// </summary>
        /// <param name="userId">Id of user to fetch</param>
        /// <returns></returns>
        [HttpGet("{userId}/loyalty")]
        public async Task<IActionResult> GetLoyaltyDataByUserId(int userId)
        {
            var loyaltyData = await _userService.GetLoyaltyDataByUserIdAsync(userId);
            return Ok();
        }
        /// <summary>
        /// Get recent user activity or history
        /// </summary>
        /// <param name="userId">Id of user to fetch</param>
        /// <returns></returns>
        [HttpGet("{userId}/activity")]
        public async Task<IActionResult> GetUserActivityByUserId(int userId)
        {
            var activity = await _userService.GetUserActivityByUserIdAsync(userId);
            return Ok();
        }
        /// <summary>
        /// Get user-specific settings like UI preferences, toggles
        /// </summary>
        /// <param name="userId">Id of user to fetch</param>
        /// <returns></returns>
        [HttpGet("{userId}/settings")]
        public async Task<IActionResult> GetUserSettingsByUserId(int userId)
        {
            var settings = await _userService.GetUserSettingsByUserIdAsync(userId);
            return Ok();
        }
    }
}
