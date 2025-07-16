using Microsoft.AspNetCore.Mvc;
using ShippingService.Services.Interfaces;

namespace ShippingService.Controller.v1
{
    [ApiController]
    [Route("api/v1/shipping")]
    public class ShippingController : ControllerBase
    {
        private readonly IShippingService _shippingService;
        public ShippingController(IShippingService shippingService)
        {
            _shippingService = shippingService;
        }

        /// <summary>
        /// Get the shipping status of an order using its provided Id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>The status of the shipment in string format</returns>
        [HttpGet("{orderId}/status")]
        public async Task<IActionResult> GetShippingStatusOfOrder(string orderId)
        {
            await _shippingService.GetShippingStatusOfOrderAsync(orderId);
            return Ok();
        }

        /// <summary>
        /// Creates a shipping label via the designated Courier API
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns> The shipping label </returns>
        [HttpPost("{orderId}/create-label")]
        public async Task<IActionResult> CreateShippingLabel(string orderId)
        {
            await _shippingService.CreateShippingLabelAsync(orderId);
            return Ok();
        }

        /// <summary>
        /// Retrieves the latest tracking information via the designated Courier API
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpPost("{orderId}/track")]
        public async Task<IActionResult> FetchLatestTrackingDataFromCourier(string orderId)
        {
            await _shippingService.FetchLatestTrackingDataFromCourierAsync(orderId);
            return Ok();
        }

        /// <summary>
        /// Gets a list of all currently supported couriers
        /// </summary>
        /// <returns>A List of Courier objects</returns>
        [HttpGet("carriers")]
        public async Task<IActionResult> GetSupportedCouriers()
        {
            await _shippingService.GetSupportedCouriersAsync();
            return Ok();
        }

        /// <summary>
        /// Calculates the shipping costs and time estimations
        /// </summary>
        /// <returns> A ShippingCalculation object</returns>
        [HttpPost("calculate")]
        public async Task<IActionResult> CalculateShippingCostsAndTime(string orderId)
        {
            await _shippingService.CalculateShippingCostsAndTimeAsync(orderId);
            return Ok();
        }

        /// <summary>
        /// Sends a notification to emails linked with orders, which have been delayed
        /// </summary>
        /// <returns> Confirmation that emails were sent </returns>
        [HttpPost("notify-delay")]
        public async Task<IActionResult> NotifyOfOrderDelays()
        {
            await _shippingService.NotifyOfOrderDelaysAsync();
            return Ok();
        }

        /// <summary>
        /// Makes a standard health check for the API
        /// </summary>
        /// <returns>A string representation of the health check results </returns>
        [HttpGet("health")]
        public async Task<IActionResult> HealthCheck()
        {
            await _shippingService.HealthCheckAsync();
            return Ok();
        }
    }
}
