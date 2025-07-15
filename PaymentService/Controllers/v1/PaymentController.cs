using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PaymentService.Services.Interfaces;

namespace PaymentService.Controllers.v1
{
    [Route("api/v1/payments")]
    [ApiController]
    [Authorize]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        /// <summary>
        /// Should initialize the PaymentService through dependency injection
        /// </summary>
        /// <param name="paymentService">Service handling Payment-related business logic</param>
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        /// <summary>
        /// Initiate a new payment transaction
        /// </summary>
        /// <param name="payment">New Payment to create</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreatePaymentTransaction(object payment)
        {
            var newPayment = await _paymentService.CreatePaymentTransactionAsync(payment);
            return Ok(newPayment);
        }
        /// <summary>
        /// Get payment status/details by payment ID
        /// </summary>
        /// <param name="paymentId">Id of payment to fetch</param>
        /// <returns></returns>
        [HttpGet("{paymentId}")]
        public async Task<IActionResult> GetPaymentDetailsById(int paymentId)
        {
            var payment = await _paymentService.GetPaymentDetailsByIdAsync(paymentId);
            return Ok(payment);
        }
        /// <summary>
        /// Issue a refund for a specific payment
        /// </summary>
        /// <param name="paymentId">Id of payment to refund</param>
        /// <returns></returns>
        [HttpPost("{paymentId}/refund")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RefundPayment(int paymentId)
        {
            var refundStatus = await _paymentService.RefundPaymentAsync(paymentId);
            return Ok(refundStatus);
        }

        /// <summary>
        /// Get inventory snapshot for a warehouse
        /// </summary>
        /// <param name="warehouseId">Id of warehouse of the inventory snapshot to fetch</param>
        /// <returns></returns>
        [HttpGet("/user/{userId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllPaymentsByUserId(int userId)
        {
            var paymentList = await _paymentService.GetAllPaymentsByUserIdAsync(userId);
            return Ok(paymentList);
        }
    }
}
