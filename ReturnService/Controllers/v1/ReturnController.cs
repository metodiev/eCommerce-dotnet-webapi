using Microsoft.AspNetCore.Mvc;
using ReturnService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ReturnService.Controllers.v1
{
    [ApiController]
    [Route("api/v1/returns")]
    public class ReturnController : ControllerBase
    {
        private readonly IReturnService _returnService;

        public ReturnController(IReturnService returnService)
        {
            _returnService = returnService;
        }

        /// <summary>
        /// Creates a new return for an order or item
        /// </summary>
        /// <returns> Confirmation that return was created </returns>
        [HttpPost]
        public async Task<IActionResult> CreateReturnRequest([FromBody] object returnRequest)
        {
            var result = await _returnService.CreateReturnRequestAsync(returnRequest);
            return Ok(result);
        }

        /// <summary>
        /// Get return details by its provided Id
        /// </summary>
        /// <returns> A ReturnRequest object </returns>
        [HttpGet("{returnId}")]
        public async Task<IActionResult> GetReturnRequestById(string returnId)
        {
            var result = await _returnService.GetReturnRequestByIdAsync(returnId);
            return Ok(result);
        }

        /// <summary>
        /// Get all of the return requests made by a user
        /// </summary>
        /// <returns> A List of ReturnRequest Objects </returns>
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetAllUserReturnRequestsByUserId(string userId)
        {
            var result = await _returnService.GetAllUserReturnRequestsByUserIdAsync(userId);
            return Ok(result);
        }

        /// <summary>
        /// Cancels a return request
        /// </summary>
        /// <returns> Confirmation that return request was cancelled</returns>

        [HttpPut("{returnId}/cancel")]
        public async Task<IActionResult> CancelReturnRequest(string returnId)
        {
            var result = await _returnService.CancelReturnRequestAsync(returnId);
            return Ok(result);
        }

        /// <summary>
        /// Approve a return request
        /// </summary>
        /// <returns> Confirmation that return request was approved </returns>
        [HttpPut("{returnId}/approve")]
        public async Task<IActionResult> ApproveReturnRequest(string returnId)
        {
            var result = await _returnService.ApproveReturnRequestAsync(returnId);
            return Ok();
        }

        /// <summary>
        /// Reject a return request
        /// </summary>
        /// <returns> Confirmation that return request was rejected.</returns>
        [HttpPut("{returnId}/reject")]
        public async Task<IActionResult> RejectReturnRequest(string returnId) //Maybe include reason for rejection here as well?
        {
            var result = await _returnService.RejectReturnRequestAsync(returnId);
            return Ok();
        }

        /// <summary>
        /// Retrieve the status of a return request by its Id
        /// </summary>
        /// <returns> The status of the return request in string format </returns>
        [HttpGet("{returnId}/refund-status")]
        public async Task<IActionResult> GetReturnRequestStatus(string returnId)
        {
            var result = await _returnService.GetReturnRequestStatusAsync(returnId);
            return Ok();
        }

        /// <summary>
        /// Upload any required evidence for making a return request
        /// </summary>
        /// <returns>Boolean signifying if evidence was uploaded correctly </returns>
        [HttpPost("{returnId}/upload-evidence")]
        public async Task<IActionResult> UploadReturnRequestEvidence(string returnId, [FromBody] List<Blob> requestEvidence)
        {
            var result = await _returnService.UploadReturnRequestEvidenceAsync(returnId, requestEvidence);
            return Ok();
        }


        /// <summary>
        /// Gets a list of all eligible reasons for making a return request
        /// </summary>
        /// <returns>List<string> containing all the eligible reasons. </string></returns>
        [HttpGet("reasons")]
        public async Task<IActionResult> GetReturnRequestReasons()
        {
            var result = await _returnService.GetReturnRequestReasonsAsync();
            return Ok();
        }

        /// <summary>
        /// Standard health check endpoint
        /// </summary>
        /// <returns> Result of health check in string format </returns>
        [HttpGet("health")]
        public async Task<IActionResult> HealthCheck()
        {
            var result = await _returnService.HealthCheckAsync();
            return Ok();
        }
    }
}
