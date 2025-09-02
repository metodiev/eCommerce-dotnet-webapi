using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationService.Services.Interfaces
{
    public interface INotificationService
    {
        Task<object> CreateNotificationTemplateAsync(object template);
        Task DeleteNotificationTemplateAsync(string templateId);
        Task<IList<object>> GetAllNotificationTemplatesAsync();
        Task<object> GetNotificationStatusAsync(string notificationId);
        Task HealthCheckAsync();
        Task<object> SendEmailNotificationAsync(object notification);
        Task<object> SendPushNotificationAsync(object notification);
        Task<object> SendSMSNotificationAsync(object notification);
        Task<object> UpdateNotificationTemplateAsync(string templateId, object template);
    }
}
