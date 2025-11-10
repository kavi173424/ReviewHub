using Microsoft.AspNetCore.Mvc;
using ReviewHubOrchestrationAPI.Models;
using ReviewHubOrchestrationAPI.Services;
using ReviewHubOrchestrationAPI.Validators;

namespace OrchestrationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly PublicApiService _publicApiService;
        private readonly ReviewValidator _validator;

        public ReviewController(PublicApiService publicApiService, ReviewValidator validator)
        {
            _publicApiService = publicApiService;
            _validator = validator;
        }

        // POST api/review/fetch
        [HttpPost("fetch")]
        public IActionResult FetchReview([FromBody] ReviewRequestModel request)
        {
            // 1️⃣ Validate inputs
            var validationResult = _validator.Validate(request);
            if (!validationResult.IsValid)
            {
                return BadRequest(new
                {
                    message = "Invalid request",
                    errors = validationResult.Errors
                });
            }

            // 2️⃣ Call service to process logic
            var response = _publicApiService.GetReviewSummary(request);

            // 3️⃣ Return structured response
            return Ok(response);
        }
    }
}
