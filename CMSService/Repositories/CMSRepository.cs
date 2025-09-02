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

        public Task DeleteBlogPostAsync(string blogId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCMSPageAsync(string pageId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFAQAsync(string faqId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetAllCMSPagesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBlogPostByIdAsync(string blogId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<object>> GetBlogPostsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetCMSPageByIdAsync(string pageId)
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

        public Task<object> UpdateBlogPostAsync(string blogId, object blog)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateCMSPageAsync(string pageId, object page)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateFAQAsync(string faqId, object faq)
        {
            throw new NotImplementedException();
        }
    }
}
