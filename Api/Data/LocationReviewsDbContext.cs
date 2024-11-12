using Api.Features.Account;
using Api.Features.Review;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;

public class LocationReviewsDbContext(DbContextOptions<LocationReviewsDbContext> options)
    : IdentityDbContext<IdentityUser>(options)
{
    public DbSet<Account> Account { get; set; }
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
    }
}