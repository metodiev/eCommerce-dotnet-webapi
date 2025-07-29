using CMSService.Repositories.Interfaces;
using CMSService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMSService.Services
{
    public class CMSService : ICMSService
    {
        private readonly ICMSRepository _cmsRepository;
        public CMSService(ICMSRepository cmsRepository)
        {
            _cmsRepository = cmsRepository;
        }
        public async Task<object> CreateBlogPostAsync(object blog)
        {
            return await _cmsRepository.CreateBlogPostAsync(blog);
        }

        public async Task<object> CreateCMSPageAsync(object page)
        {
            return await _cmsRepository.CreateCMSPageAsync(page);
        }

        public async Task<object> CreateFAQAsync(object faq)
        {
            return await _cmsRepository.CreateFAQAsync(faq);
        }

        public async Task DeleteBlogPostAsync(int blogId)
        {
            await _cmsRepository.DeleteBlogPostAsync(blogId);
        }

        public async Task DeleteCMSPageAsync(int pageId)
        {
            await _cmsRepository.DeleteCMSPageAsync(pageId);
        }

        public async Task DeleteFAQAsync(int faqId)
        {
            await _cmsRepository.DeleteFAQAsync(faqId);
        }

        public async Task<IList<object>> GetAllCMSPagesAsync()
        {
            return await _cmsRepository.GetAllCMSPagesAsync();
        }

        public async Task<object> GetBlogPostByIdAsync(int blogId)
        {
            return await _cmsRepository.GetBlogPostByIdAsync(blogId);
        }

        public async Task<IList<object>> GetBlogPostsAsync()
        {
            return await _cmsRepository.GetBlogPostsAsync();
        }

        public async Task<object> GetCMSPageByIdAsync(int pageId)
        {
            return await _cmsRepository.GetCMSPageByIdAsync(pageId);
        }

        public async Task<IList<object>> GetFAQListAsync()
        {
            return await _cmsRepository.GetFAQListAsync();
        }

        public async Task HealthCheckAsync()
        {
            await _cmsRepository.HealthCheckAsync();
        }

        public async Task<object> UpdateBlogPostAsync(int blogId, object blog)
        {
            return await _cmsRepository.UpdateBlogPostAsync(blogId, blog);
        }

        public async Task<object> UpdateCMSPageAsync(int pageId, object page)
        {
            return await _cmsRepository.UpdateCMSPageAsync(pageId, page);
        }

        public async Task<object> UpdateFAQAsync(int faqId, object faq)
        {
            return await _cmsRepository.UpdateFAQAsync(faqId, faq);
        }
    }
}
