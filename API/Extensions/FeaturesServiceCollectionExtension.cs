using API.Features.Common.Interfaces;
using API.Features.Review;
using API.Features.Review.DTO;
using API.Features.Review.Interfaces;
using API.Features.Review.Mappers;

namespace API.Extensions;

public static class FeaturesServiceCollectionExtension
{
    public static void AddApiFeaturesServices(this IServiceCollection services)
    {
        // Feature/Account Services:
        
        // Feature/Location Services:
        
        // Feature/Review Services:
        services
            .AddScoped<IReviewService, ReviewService>()
            .AddScoped<IMapper<Review, ReviewRequest>, ReviewRequestMapper>()
            .AddScoped<IMapper<Review, ReviewResponse>, ReviewResponseMapper>()
            .AddScoped<IReviewRepository, ReviewRepository>();
    }
}