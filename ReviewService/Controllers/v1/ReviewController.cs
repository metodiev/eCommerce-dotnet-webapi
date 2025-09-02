using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using ReviewService.Services.Interfaces;

namespace ReviewService.Controllers.v1
{
    [ApiController]
    [Route("api/v1/reviews")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }


        /// <summary>
        /// Creates a new review
        /// </summary>
        /// <param name="review"></param>
        /// <returns> Confirmation that a review was made </returns>
        [HttpPost]
        public async Task<IActionResult> SubmitNewReview([FromBody] object review)
        {
            var result = await _reviewService.SubmitNewReviewAsync(review);
            return Ok(result);
        }


        /// <summary>
        /// Retrieves all reviews made for a specific product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns> A List of Review objects </returns>
        [HttpGet("product/{productId}")]
        public async Task<IActionResult> GetAllApprovedReviewsForProduct(string productId)
        {
            var result = await _reviewService.GetAllApprovedReviewsForProductAsync(productId);
            return Ok(result);
        }


        /// <summary>
        /// Retrieves all the reviews made by a specific user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns> A List of Review objects </returns>
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetAllReviewsByUser(string userId)
        {
            var result = await _reviewService.GetAllReviewsByUserAsync(userId);
            return Ok(result);
        }


        /// <summary>
        /// Updates an existing review
        /// </summary>
        /// <param name="reviewId"></param>
        /// <param name="updatedReview"></param>
        /// <returns> Confirmation that review was updated </returns>
        [HttpPut("{reviewId}")]
        public async Task<IActionResult> UpdateReview(string reviewId, [FromBody] object updatedReview)
        {
            var result = await _reviewService.UpdateReviewAsync(reviewId, updatedReview);
            return Ok(result);
        }


        /// <summary>
        /// Deletes a review
        /// </summary>
        /// <param name="reviewId"></param>
        /// <returns> Confirmation that review was deleted </returns>
        [HttpDelete("{reviewId}")]
        public async Task<IActionResult> DeleteReview(string reviewId)
        {
            var result = await _reviewService.DeleteReviewAsync(reviewId);
            return Ok(result);
        }


        /// <summary>
        /// Gets a list of all pending reviews
        /// </summary>
        /// <returns> a List of Review objects </returns>
        [HttpGet("pending")]
        public async Task<IActionResult> GetAllPendingReviews()
        {
            var result = _reviewService.GetAllPendingReviewsAsync();
            return Ok(result);
        }


        /// <summary>
        /// Approve a review, making it visible for all users
        /// </summary>
        /// <param name="reviewId"></param>
        /// <returns> Confirmation that review was approved </returns>
        [HttpPut("{reviewId}/approve")]
        public async Task<IActionResult> ApproveReview(string reviewId)
        {
            var result = await _reviewService.ApproveReviewAsync(reviewId);
            return Ok(result);
        }


        /// <summary>
        /// Rejects a review, making it hidden for normal users
        /// </summary>
        /// <param name="reviewId"></param>
        /// <returns> Confirmation that review was rejected </returns>
        [HttpPut("{reviewId}/reject")]
        public async Task<IActionResult> RejectReview(string reviewId)
        {
            var result = await _reviewService.RejectReviewAsync(reviewId);
            return Ok(result);
        }

        /// <summary>
        /// Makes a report for a specific review, flagging it as inappropriate
        /// </summary>
        /// <param name="reviewId"></param>
        /// <returns> Confirmation that Report was made </returns>
        [HttpPost("{reviewId}/report")]
        public async Task<IActionResult> ReportReview(string reviewId, [FromBody] string reportReason)
        {
            var result = await _reviewService.ReportReviewAsync(reviewId, reportReason);
            return Ok(result);
        }


        /// <summary>
        /// Standard health check endpoint
        /// </summary>
        /// <returns> Status of the service in string format </returns>
        [HttpGet("health")]
        public async Task<IActionResult> HealthCheck()
        {
            var result = await _reviewService.HealthCheckAsync();
            return Ok(result);
        }
    }
}
