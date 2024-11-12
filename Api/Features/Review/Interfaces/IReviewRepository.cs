using System.Linq.Expressions;

namespace Api.Features.Review.Interfaces;

public interface IReviewRepository
{
    Task<Review?> AddReviewAsync(Review review);
    Task<Review?> GetReviewByIdAsync(Guid id);
    Task<IEnumerable<Review>> GetReviewPagedAsync(int pageNumber, int pageSize);
    Task<IEnumerable<Review>> FindReviewAsync(Expression<Func<Review, bool>> predicate);
    Task<Review?> UpdateReviewAsync(Review review);
    Task<Review?> DeleteReviewByIdAsync(Guid id);
}