namespace API.Features.Review.DTO;

public class ReviewResponse
{
    public required Guid Id { get; set; }
    public required Guid AccountId { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public DateTime DatePosted { get; set; }
}