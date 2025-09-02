using ReviewService.Repositories.Interfaces;
using ReviewService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewService.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        public async Task<bool> ApproveReviewAsync(string reviewId)
        {
            return await _reviewRepository.ApproveReviewAsync(reviewId);
        }

        public async Task<bool> DeleteReviewAsync(string reviewId)
        {
            return await _reviewRepository.DeleteReviewAsync(reviewId);
        }

        public async Task<List<object>> GetAllApprovedReviewsForProductAsync(string productId)
        {
            return await _reviewRepository.GetAllApprovedReviewsForProductAsync(productId);
        }

        public async Task<List<object>> GetAllPendingReviewsAsync()
        {
            return await _reviewRepository.GetAllPendingReviewsAsync();
        }

        public async Task<List<object>> GetAllReviewsByUserAsync(string userId)
        {
            return await _reviewRepository.GetAllReviewsByUserAsync(userId);
        }

        public async Task<string> HealthCheckAsync()
        {
            return await _reviewRepository.HealthCheckAsync();
        }

        public async Task<bool> RejectReviewAsync(string reviewId)
        {
            return await _reviewRepository.RejectReviewAsync(reviewId);
        }

        public async Task<bool> ReportReviewAsync(string reviewId, string reportReason)
        {
            return await _reviewRepository.ReportReviewAsync(reviewId, reportReason);
        }

        public async Task<bool> SubmitNewReviewAsync(object review)
        {
            return await _reviewRepository.SubmitNewReviewAsync(review);
        }

        public async Task<bool> UpdateReviewAsync(string reviewId, object updatedReview)
        {
            return await _reviewRepository.UpdateReviewAsync(reviewId, updatedReview);
        }
    }
}
