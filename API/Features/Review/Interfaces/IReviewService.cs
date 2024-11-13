using System.Linq.Expressions;
using API.Features.Review.DTO;

namespace API.Features.Review.Interfaces;

public interface IReviewService
{
    Task<ReviewResponse?> AddReviewAsync(ReviewRequest reviewRequest);
    Task<ReviewResponse?> GetReviewByIdAsync(Guid id);
    Task<IEnumerable<ReviewResponse>?> GetReviewPagedAsync(int pageNumber, int pageSize);
    Task<IEnumerable<ReviewResponse>?> FindReviewAsync(Expression<Func<ReviewResponse, bool>> predicate);
    Task<ReviewResponse?> UpdateReviewAsync(ReviewRequest reviewRequest);
    Task<ReviewResponse?> DeleteReviewByIdAsync(Guid id);
}