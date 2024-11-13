namespace API.Features.Account;

public class Account
{
    public required Guid Id { get; set; }
    public required string UserName { get; set; }
    public required string FirstName { get; set; } = string.Empty;
    public required string LastName { get; set; } = string.Empty;
    public required string HashedPassword { get; set; } = string.Empty;
    public required string Email { get; set; } = string.Empty;
    
    // Navigation properties
    public virtual ICollection<Review.Review> Reviews { get; set; } = new HashSet<Review.Review>();
}