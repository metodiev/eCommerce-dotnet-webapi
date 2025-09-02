using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewService.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        Task<bool> SubmitNewReviewAsync(object review);
        Task<List<object>> GetAllApprovedReviewsForProductAsync(string productId);
        Task<List<object>> GetAllReviewsByUserAsync(string userId);
        Task<bool> UpdateReviewAsync(string reviewId, object updatedReview);
        Task<bool> DeleteReviewAsync(string reviewId);
        Task<List<object>> GetAllPendingReviewsAsync();
        Task<bool> ApproveReviewAsync(string reviewId);
        Task<bool> RejectReviewAsync(string reviewId);
        Task<bool> ReportReviewAsync(string reviewId, string reportReason);
        Task<string> HealthCheckAsync();
    }
}
