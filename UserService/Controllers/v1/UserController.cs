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
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Internal")]
        public async Task<IActionResult> CreateUser([FromBody] object value)
        {
            var newUser = await _userService.CreateUserAsync(value);
            return Ok(newUser);
        }

        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateUserProfileDetails(int userId, [FromBody] object user)
        {
            var updatedProfile = await _userService.UpdateUserProfileDetailsAsync(userId, user);
            return Ok(updatedProfile);
        }
        [HttpPut("{userId}/preferences")]
        public async Task<IActionResult> UpdateUserPreferences(int userId, [FromBody] object preferences)
        {
            var updatedPreferences = await _userService.UpdateUserPreferencesAsync(userId, preferences);
            return Ok(updatedPreferences);
        }
        [HttpPut("{userId}/settings")]
        public async Task<IActionResult> UpdateUserSettings(int userId, [FromBody] object settings)
        {
            var updatedSettings = await _userService.UpdateUserSettingsAsync(userId, settings);
            return Ok(updatedSettings);
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            await _userService.DeleteUserAsync(userId);
            return Ok();
        }
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserById(int userId)
        {
            var user = await _userService.GetUserByIdAsync(userId);
            return Ok(user);
        }
        [HttpGet("{userId}/preferences")]
        public async Task<IActionResult> GetPreferencesByUserId(int userId)
        {
            var preferences = await _userService.GetPreferencesByUserIdAsync(userId);
            return Ok();
        }
        [HttpGet("{userId}/loyalty")]
        public async Task<IActionResult> GetLoyaltyDataByUserId(int userId)
        {
            var loyaltyData = await _userService.GetLoyaltyDataByUserIdAsync(userId);
            return Ok();
        }
        [HttpGet("{userId}/activity")]
        public async Task<IActionResult> GetUserActivityByUserId(int userId)
        {
            var activity = await _userService.GetUserActivityByUserIdAsync(userId);
            return Ok();
        }
        [HttpGet("{userId}/settings")]
        public async Task<IActionResult> GetUserSettingsByUserId(int userId)
        {
            var settings = await _userService.GetUserSettingsByUserIdAsync(userId);
            return Ok();
        }
    }
}
