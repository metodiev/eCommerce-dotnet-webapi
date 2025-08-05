using NotificationService.Repositories.Interfaces;
using NotificationService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationService.Services
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;
        public NotificationService(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public async Task<object> CreateNotificationTemplateAsync(object template)
        {
            return await _notificationRepository.CreateNotificationTemplateAsync(template); 
        }

        public async Task DeleteNotificationTemplateAsync(int templateId)
        {
            await _notificationRepository.DeleteNotificationTemplateAsync(templateId);
        }

        public async Task<IList<object>> GetAllNotificationTemplatesAsync()
        {
            return await _notificationRepository.GetAllNotificationTemplatesAsync();
        }

        public async Task<object> GetNotificationStatusAsync(int notificationId)
        {
            return await _notificationRepository.GetNotificationStatusAsync(notificationId);
        }

        public async Task HealthCheckAsync()
        {
            await _notificationRepository.HealthCheckAsync();
        }

        public async Task<object> SendEmailNotificationAsync(object notification)
        {
            return await _notificationRepository.SendEmailNotificationAsync(notification);
        }

        public async Task<object> SendPushNotificationAsync(object notification)
        {
            return await _notificationRepository.SendPushNotificationAsync(notification);
        }

        public async Task<object> SendSMSNotificationAsync(object notification)
        {
            return await _notificationRepository.SendSMSNotificationAsync(notification);
        }

        public async Task<object> UpdateNotificationTemplateAsync(int templateId, object template)
        {
            return await _notificationRepository.UpdateNotificationTemplateAsync(templateId, template);
        }
    }
}
