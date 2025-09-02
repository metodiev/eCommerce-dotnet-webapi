using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotificationService.Services.Interfaces;

namespace NotificationService.Controllers.v1
{
    [Route("api/v1/notifications")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        /// <summary>
        /// Should initialize the NotificationService through dependency injection
        /// </summary>
        /// <param name="notificationService">Service handling Notification-related business logic</param>
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        /// <summary>
        /// Send an email notification
        /// </summary>
        /// <param name="notification">Notification to send</param>
        /// <returns></returns>
        [HttpPost("email")]
        [Authorize(Roles = "Internal")]
        public async Task<IActionResult> SendEmailNotification(object notification)
        {
            var result = await _notificationService.SendEmailNotificationAsync(notification);
            return Ok(result);
        }
        /// <summary>
        /// Send a push notification
        /// </summary>
        /// <param name="notification">Notification to send</param>
        /// <returns></returns>
        [HttpPost("push")]
        [Authorize(Roles = "Internal")]
        public async Task<IActionResult> SendPushNotification(object notification)
        {
            var result = await _notificationService.SendPushNotificationAsync(notification);
            return Ok(result);
        }
        /// <summary>
        /// Send an SMS notification
        /// </summary>
        /// <param name="notification">Notification to send</param>
        /// <returns></returns>
        [HttpPost("sms")]
        [Authorize(Roles = "Internal")]
        public async Task<IActionResult> SendSMSNotification(object notification)
        {
            var result = await _notificationService.SendSMSNotificationAsync(notification);
            return Ok(result);
        }
        /// <summary>
        /// Get all notification templates
        /// </summary>
        /// <returns></returns>
        [HttpGet("templates")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllNotificationTemplates()
        {
            var templates = await _notificationService.GetAllNotificationTemplatesAsync();
            return Ok(templates);
        }
        /// <summary>
        /// Create a new notification template
        /// </summary>
        /// <param name="template">New template to create</param>
        /// <returns></returns>
        [HttpPost("templates")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateNotificationTemplate(object template)
        {
            var newTemplate = await _notificationService.CreateNotificationTemplateAsync(template);
            return Ok(newTemplate);
        }
        /// <summary>
        /// Update a notification template
        /// </summary>
        /// <param name="templateId">Id of template to update</param>
        /// <param name="template">Updated template object</param>
        /// <returns></returns>
        [HttpPut("templates/{templateId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateNotificationTemplate(string templateId, object template)
        {
            var newTemplate = await _notificationService.UpdateNotificationTemplateAsync(templateId, template);
            return Ok(newTemplate);
        }
        /// <summary>
        /// Delete a notification template
        /// </summary>
        /// <param name="templateId">Id of template to delete</param>
        /// <returns></returns>
        [HttpDelete("templates/{templateId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteNotificationTemplate(string templateId)
        {
            await _notificationService.DeleteNotificationTemplateAsync(templateId);
            return Ok();
        }
        /// <summary>
        /// Get the status of a sent notification
        /// </summary>
        /// <param name="notificationId">Id of notification to fetch status for</param>
        /// <returns></returns>
        [HttpDelete("status/{notificationId}")]
        [Authorize(Roles = "Internal")]
        public async Task<IActionResult> GetNotificationStatus(string notificationId)
        {
            var status = await _notificationService.GetNotificationStatusAsync(notificationId);
            return Ok(status);
        }
        /// <summary>
        /// Health check for the NotificationService
        /// </summary>
        /// <returns></returns>
        [HttpGet("health")]
        public async Task<IActionResult> HealthCheck()
        {
            await _notificationService.HealthCheckAsync();
            return Ok();
        }
    }
}
