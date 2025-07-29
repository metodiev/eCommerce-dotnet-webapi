using System;
using System.Collections.Generic;
using System.Text;

namespace CMSService.Repositories.Interfaces
{
    public interface ICMSRepository
    {
        Task<object> CreateBlogPostAsync(object blog);
        Task<object> CreateCMSPageAsync(object page);
        Task<object> CreateFAQAsync(object faq);
        Task DeleteBlogPostAsync(int blogId);
        Task DeleteCMSPageAsync(int pageId);
        Task DeleteFAQAsync(int faqId);
        Task<IList<object>> GetAllCMSPagesAsync();
        Task<object> GetBlogPostByIdAsync(int blogId);
        Task<IList<object>> GetBlogPostsAsync();
        Task<object> GetCMSPageByIdAsync(int pageId);
        Task<IList<object>> GetFAQListAsync();
        Task HealthCheckAsync();
        Task<object> UpdateBlogPostAsync(int blogId, object blog);
        Task<object> UpdateCMSPageAsync(int pageId, object page);
        Task<object> UpdateFAQAsync(int faqId, object faq);
    }
}
