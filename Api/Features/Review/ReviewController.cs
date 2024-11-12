using Api.Features.Review.DTO;
using Api.Features.Review.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Review;

[ApiController]
[Route("api/[controller]")]
public class ReviewController(ILogger<ReviewController> logger, IReviewService reviewService) : ControllerBase
{
    [HttpPost(Name = "AddReviewAsync")]
    public async Task<ActionResult<ReviewResponse>> AddReviewAsync([FromBody] ReviewRequest reviewRequest)
    {
        ReviewResponse? reviewResponse = await reviewService.AddReviewAsync(reviewRequest);
        
        return reviewResponse is null
            ? BadRequest("Failed to add review")
            : Ok(reviewResponse);
    }
    
    [HttpGet("{id:guid}", Name = "GetReviewByIdAsync")]
    public async Task<ActionResult<ReviewResponse>> GetReviewByIdAsync(Guid id)
    {
        ReviewResponse? reviewResponse = await reviewService.GetReviewByIdAsync(id);
        
        return reviewResponse is null
            ? NotFound("Review not found")
            : Ok(reviewResponse);
    }
}