using NotificationService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationService.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        public Task<object> CreateNotificationTemplateAsync(object template)
        {
            throw new NotImplementedException();
        }

        public Task DeleteNotificationTemplateAsync(string templateId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllNotificationTemplatesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetNotificationStatusAsync(string notificationId)
        {
            throw new NotImplementedException();
        }

        public Task HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> SendEmailNotificationAsync(object notification)
        {
            throw new NotImplementedException();
        }

        public Task<object> SendPushNotificationAsync(object notification)
        {
            throw new NotImplementedException();
        }

        public Task<object> SendSMSNotificationAsync(object notification)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateNotificationTemplateAsync(string templateId, object template)
        {
            throw new NotImplementedException();
        }
    }
}
