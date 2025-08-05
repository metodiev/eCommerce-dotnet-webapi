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

        public Task DeleteNotificationTemplateAsync(int templateId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllNotificationTemplatesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetNotificationStatusAsync(int notificationId)
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

        public Task<object> UpdateNotificationTemplateAsync(int templateId, object template)
        {
            throw new NotImplementedException();
        }
    }
}
