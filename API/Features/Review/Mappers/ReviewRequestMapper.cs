using API.Features.Common.Interfaces;
using API.Features.Review.DTO;

namespace API.Features.Review.Mappers;

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