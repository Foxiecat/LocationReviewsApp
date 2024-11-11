using Microsoft.EntityFrameworkCore;
using shared.Models;

namespace Api.Data;

public class LocationReviewsDbContext(DbContextOptions<LocationReviewsDbContext> options) : DbContext(options)
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Review> Reviews { get; set; }

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