namespace Api.Features.Review;

public class Review
{
    public Guid Id { get; set; }
    public Guid AccountId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DatePosted { get; set; }
    
    public virtual Account.Account? Account { get; set; }
}