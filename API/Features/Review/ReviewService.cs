using System.Linq.Expressions;
using API.Features.Common.Interfaces;
using API.Features.Review.DTO;
using API.Features.Review.Interfaces;

namespace API.Features.Review;

public class ReviewService(ILogger<ReviewService> logger,
                           IMapper<Review, ReviewRequest> requestMapper,
                           IMapper<Review, ReviewResponse> responseMapper,
                           IReviewRepository reviewRepository) : IReviewService
{
    public async Task<ReviewResponse?> AddReviewAsync(ReviewRequest reviewRequest)
    {
        Review review = requestMapper.MapToModel(reviewRequest);
        
        review.Id = Guid.NewGuid();
        review.AccountId = Guid.Parse("45b9c4ee-a0e3-11ef-8c69-41db891cf166");
        review.Title = reviewRequest.Title;
        review.Content = reviewRequest.Content;
        review.DatePosted = DateTime.UtcNow;
        
        Review? addedReview = await reviewRepository.AddReviewAsync(review);
        
        return addedReview is null
            ? null
            : responseMapper.MapToDTO(addedReview);
    }
    
    public async Task<ReviewResponse?> GetReviewByIdAsync(Guid id)
    {
        if (id == Guid.Empty)
        {
            logger.LogWarning("Review id {id} cannot be empty", id);
            return null;
        }
        
        Review? review = await reviewRepository.GetReviewByIdAsync(id);

        return review is null
            ? null
            : responseMapper.MapToDTO(review);
    }

    public async Task<IEnumerable<ReviewResponse>> GetReviewPagedAsync(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<ReviewResponse>> FindReviewAsync(Expression<Func<ReviewResponse, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public async Task<ReviewResponse> UpdateReviewAsync(ReviewRequest reviewRequest)
    {
        throw new NotImplementedException();
    }

    public async Task<ReviewResponse> DeleteReviewByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}