using GameReviewWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EpicalyxGameReviews.Data
{
    public class ReviewContext : DbContext
    {
        public ReviewContext(DbContextOptions<ReviewContext> options) : base(options)
        {
        }

        public DbSet<Games> Games { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<FinalReview> FinalReview { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games>().ToTable("Games");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<FinalReview>().ToTable("FinalReview");
        }
    }
}