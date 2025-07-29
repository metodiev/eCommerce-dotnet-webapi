using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CMSService.Services.Interfaces;

namespace CMSService.Controllers.v1
{
    [Route("api/v1/cms")]
    [ApiController]
    public class CMSController : ControllerBase
    {
        private readonly ICMSService _cmsService;
        /// <summary>
        /// Should initialize the CMSService through dependency injection
        /// </summary>
        /// <param name="cmsService">Service handling CMS-related business logic</param>
        public CMSController(ICMSService cmsService)
        {
            _cmsService = cmsService;
        }
        /// <summary>
        /// Get all CMS pages
        /// </summary>
        /// <returns></returns>
        [HttpGet("pages")]
        public async Task<IActionResult> GetAllCMSPages()
        {
            var pages = await _cmsService.GetAllCMSPagesAsync();
            return Ok(pages);
        }
        /// <summary>
        /// Get CMS page details by ID
        /// </summary>
        /// <param name="pageId">Id of page to fetch</param>
        /// <returns></returns>
        [HttpGet("pages/{pageId}")]
        public async Task<IActionResult> GetCMSPageById(int pageId)
        {
            var page = await _cmsService.GetCMSPageByIdAsync(pageId);
            return Ok(page);
        }
        /// <summary>
        /// Create a new CMS page
        /// </summary>
        /// <param name="page">New page object</param>
        /// <returns></returns>
        [HttpPost("pages")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateCMSPage(object page)
        {
            var newPage = await _cmsService.CreateCMSPageAsync(page);
            return Ok(newPage);
        }
        /// <summary>
        /// Update existing CMS page
        /// </summary>
        /// <param name="pageId">Id of page</param>
        /// <param name="page">Modified page</param>
        /// <returns></returns>
        [HttpPut("pages/{pageId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateCMSPage(int pageId, object page)
        {
            var updatedPage = await _cmsService.UpdateCMSPageAsync(pageId, page);
            return Ok(updatedPage);
        }
        /// <summary>
        /// Delete CMS page
        /// </summary>
        /// <param name="pageId">Id of page to delete</param>
        /// <returns></returns>
        [HttpDelete("pages/{pageId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteCMSPage(int pageId)
        {
            await _cmsService.DeleteCMSPageAsync(pageId);
            return Ok();
        }
        /// <summary>
        /// List blog posts
        /// </summary>
        /// <returns></returns>
        [HttpGet("blogs")]
        public async Task<IActionResult> GetBlogPosts()
        {
            var blogs = await _cmsService.GetBlogPostsAsync();
            return Ok(blogs);
        }
        /// <summary>
        /// Get blog post details
        /// </summary>
        /// <param name="blogId">Id of blog post to fetch</param>
        /// <returns></returns>
        [HttpGet("blogs/{blogId}")]
        public async Task<IActionResult> GetBlogPostById(int blogId)
        {
            var blog = await _cmsService.GetBlogPostByIdAsync(blogId);
            return Ok(blog);
        }
        /// <summary>
        /// Create new blog post
        /// </summary>
        /// <param name="blog">New blog post object</param>
        /// <returns></returns>
        [HttpPost("blogs")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateBlogPost(object blog)
        {
            var newBlog = await _cmsService.CreateBlogPostAsync(blog);
            return Ok(newBlog);
        }
        /// <summary>
        /// Update blog post
        /// </summary>
        /// <param name="blogId">Id of blog post to update</param>
        /// <param name="blog">Modified blog post</param>
        /// <returns></returns>
        [HttpPut("blogs/{blogId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateBlogPost(int blogId, object blog)
        {
            var updatedBlog = await _cmsService.UpdateBlogPostAsync(blogId, blog);
            return Ok(updatedBlog);
        }
        /// <summary>
        /// Delete blog post
        /// </summary>
        /// <param name="blogId">Id of blog post to delete</param>
        /// <returns></returns>
        [HttpDelete("blogs/{blogId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteBlogPost(int blogId)
        {
            await _cmsService.DeleteBlogPostAsync(blogId);
            return Ok();
        }
        /// <summary>
        /// Get FAQ list
        /// </summary>
        /// <returns></returns>
        [HttpGet("faqs")]
        public async Task<IActionResult> GetFAQList()
        {
            var faqs = await _cmsService.GetFAQListAsync();
            return Ok(faqs);
        }
        /// <summary>
        /// Create FAQ
        /// </summary>
        /// <param name="faq">New FAQ object</param>
        /// <returns></returns>
        [HttpPost("faqs")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateFAQ(object faq)
        {
            var newFaq = await _cmsService.CreateFAQAsync(faq);
            return Ok(newFaq);
        }
        /// <summary>
        /// Update FAQ
        /// </summary>
        /// <param name="faqId">Id of FAQ to update</param>
        /// <param name="faq">Modified FAQ</param>
        /// <returns></returns>
        [HttpPut("faqs/{faqId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateFAQ(int faqId, object faq)
        {
            var updatedFaq = await _cmsService.UpdateFAQAsync(faqId, faq);
            return Ok(updatedFaq);
        }
        /// <summary>
        /// Delete FAQ
        /// </summary>
        /// <param name="faqId">Id of FAQ to delete</param>
        /// <returns></returns>
        [HttpDelete("faqs/{faqId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteFAQ(int faqId)
        {
            await _cmsService.DeleteFAQAsync(faqId);
            return Ok();
        }
        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <returns></returns>
        [HttpGet("health")]
        public async Task<IActionResult> HealthCheck()
        {
            await _cmsService.HealthCheckAsync();
            return Ok();
        }
    }
}
