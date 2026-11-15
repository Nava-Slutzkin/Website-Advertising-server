using Microsoft.EntityFrameworkCore;

namespace DAL.data
{
    public class AdvertisingContext : DbContext
    {
        public AdvertisingContext(DbContextOptions<AdvertisingContext> options)
            : base(options)
        {
        }

        public DbSet<Business> Businesses { get; set; }
        public DbSet<BusinessCategory> BusinessCategories { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ServiceOrder> ServiceOrders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.BusinessOwner)
                .WithMany(u => u.ReceivedReviews)
                .HasForeignKey(r => r.BusinessOwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Business>()
                .Property(b => b.Price)
                .HasPrecision(18, 2);
        }
    }
}