using System;
using System.Collections.Generic;
using System.Text;

namespace CMSService.Services.Interfaces
{
    public interface ICMSService
    {
        Task<object> CreateBlogPostAsync(object blog);
        Task<object> CreateCMSPageAsync(object page);
        Task<object> CreateFAQAsync(object faq);
        Task DeleteBlogPostAsync(string blogId);
        Task DeleteCMSPageAsync(string pageId);
        Task DeleteFAQAsync(string faqId);
        Task<IList<object>> GetAllCMSPagesAsync();
        Task<object> GetBlogPostByIdAsync(string blogId);
        Task<IList<object>> GetBlogPostsAsync();
        Task<object> GetCMSPageByIdAsync(string pageId);
        Task<IList<object>> GetFAQListAsync();
        Task HealthCheckAsync();
        Task<object> UpdateBlogPostAsync(string blogId, object blog);
        Task<object> UpdateCMSPageAsync(string pageId, object page);
        Task<object> UpdateFAQAsync(string faqId, object faq);
    }
}
