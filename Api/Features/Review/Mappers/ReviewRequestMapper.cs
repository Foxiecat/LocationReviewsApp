using Api.Features.Common.Interfaces;
using Api.Features.Review.DTO;

namespace Api.Features.Review.Mappers;

public class ReviewRequestMapper : IMapper<Review, ReviewRequest>
{
    public ReviewRequest MapToDTO(Review model)
    {
        return new ReviewRequest()
        {
            Title = model.Title,
            Content = model.Content
        };
    }

    public Review MapToModel(ReviewRequest dto)
    {
        return new Review()
        {
            Title = dto.Title,
            Content = dto.Content
        };
    }
}