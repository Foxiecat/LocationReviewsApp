namespace shared.Models;

public class Review
{
    public required Guid Id { get; set; }
    public required Guid ReviewerId { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public DateTime DatePosted { get; set; }
    
    public virtual Account? Account { get; set; }
}