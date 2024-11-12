using Api.Features.Common.Interfaces;
using Api.Features.Review;
using Api.Features.Review.DTO;
using Api.Features.Review.Interfaces;
using Api.Features.Review.Mappers;

namespace Api.Extensions;

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