using CMSService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMSService.Repositories
{
    public class CMSRepository : ICMSRepository
    {
        public Task<object> CreateBlogPostAsync(object blog)
        {
            throw new NotImplementedException();
        }

        public Task<object> CreateCMSPageAsync(object page)
        {
            throw new NotImplementedException();
        }

        public Task<object> CreateFAQAsync(object faq)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBlogPostAsync(int blogId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCMSPageAsync(int pageId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFAQAsync(int faqId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllCMSPagesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBlogPostByIdAsync(int blogId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetBlogPostsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetCMSPageByIdAsync(int pageId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetFAQListAsync()
        {
            throw new NotImplementedException();
        }

        public Task HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateBlogPostAsync(int blogId, object blog)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateCMSPageAsync(int pageId, object page)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateFAQAsync(int faqId, object faq)
        {
            throw new NotImplementedException();
        }
    }
}
