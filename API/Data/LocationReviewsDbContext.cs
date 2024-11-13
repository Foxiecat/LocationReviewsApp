using API.Features.Account;
using API.Features.Location;
using API.Features.Review;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class LocationReviewsDbContext(DbContextOptions<LocationReviewsDbContext> options)
    : DbContext(options)
{
    public DbSet<Account> Account { get; set; }
    public DbSet<Location> Location { get; set; }
    public DbSet<Review> Review { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Account>(options =>
        {
            options.Property(account => account.Email).IsRequired();
            
            options.HasIndex(account => account.Email).IsUnique();
            options.HasIndex(account => account.UserName).IsUnique();
        });

        modelBuilder.Entity<Review>(options =>
        {
            options
                .HasOne(review => review.Account)
                .WithMany(account => account.Reviews)
                .HasForeignKey(review => review.AccountId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Review>(options =>
        {
            options
                .HasOne(review => review.Location)
                .WithMany(location => location.Reviews)
                .HasForeignKey(review => review.LocationId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}