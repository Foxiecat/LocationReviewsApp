using System.Linq.Expressions;
using API.Data;
using API.Features.Review.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Features.Review;

public class ReviewRepository(ILogger<ReviewRepository> logger, LocationReviewsDbContext dbContext) : IReviewRepository
{
    public async Task<Review?> AddReviewAsync(Review model)
    {
        bool checkIfReviewExists = dbContext.Review.Any(review => review.Id == model.Id);
        if (checkIfReviewExists)
        {
            logger.LogWarning("Review with id {id} already exists.", model.Id);
            return null;
        }
        
        await dbContext.Review.AddAsync(model);
        await dbContext.SaveChangesAsync();
        
        return model;
    }

    public async Task<Review?> GetReviewByIdAsync(Guid id)
    {
        return await dbContext.Review.FirstOrDefaultAsync(review => review.Id == id);
    }

    public async Task<IEnumerable<Review>> GetReviewPagedAsync(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Review>> FindReviewAsync(Expression<Func<Review, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public async Task<Review?> UpdateReviewAsync(Review model)
    {
        throw new NotImplementedException();
    }

    public async Task<Review?> DeleteReviewByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}