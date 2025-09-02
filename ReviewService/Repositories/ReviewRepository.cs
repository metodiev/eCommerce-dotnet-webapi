using ReviewService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewService.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public Task<bool> ApproveReviewAsync(string reviewId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteReviewAsync(string reviewId)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetAllApprovedReviewsForProductAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetAllPendingReviewsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetAllReviewsByUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RejectReviewAsync(string reviewId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ReportReviewAsync(string reviewId, string reportReason)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SubmitNewReviewAsync(object review)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateReviewAsync(string reviewId, object updatedReview)
        {
            throw new NotImplementedException();
        }
    }
}
