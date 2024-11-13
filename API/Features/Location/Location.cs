namespace API.Features.Location;

public class Location
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<Review.Review> Reviews { get; set; } = new HashSet<Review.Review>();
}