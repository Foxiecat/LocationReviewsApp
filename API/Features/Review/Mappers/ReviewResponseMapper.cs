using API.Features.Common.Interfaces;
using API.Features.Review.DTO;

namespace API.Features.Review.Mappers;

public class ReviewResponseMapper : IMapper<Review, ReviewResponse>
{
    public ReviewResponse MapToDTO(Review model)
    {
        return new ReviewResponse
        {
            Id = model.Id,
            AccountId = model.AccountId,
            Title = model.Title,
            Content = model.Content,
            DatePosted = model.DatePosted
        };
    }

    public Review MapToModel(ReviewResponse dto)
    {
        return new Review
        {
            Id = dto.Id,
            AccountId = dto.AccountId,
            Title = dto.Title,
            Content = dto.Content,
            DatePosted = dto.DatePosted
        };
    }
}