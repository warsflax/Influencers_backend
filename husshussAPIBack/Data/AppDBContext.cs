using Microsoft.EntityFrameworkCore;
using husshussAPIBack.Models;

namespace husshussAPIBack.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Influencer> Influencers { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<SMMA> SMMAs { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurer les clés étrangères et autres relations ici
            modelBuilder.Entity<Influencer>()
                .HasOne(i => i.User)
                .WithOne()
                .HasForeignKey<Influencer>(i => i.InfluencerID);

            modelBuilder.Entity<Sponsor>()
                .HasOne(s => s.User)
                .WithOne()
                .HasForeignKey<Sponsor>(s => s.SponsorID);

             modelBuilder.Entity<SMMA>()
        .HasKey(s => s.SMMA_ID);

                modelBuilder.Entity<SMMA>()
        .HasOne(s => s.User)
        .WithOne()
        .HasForeignKey<SMMA>(s => s.SMMA_ID);
            /*

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.SentMessages)
                .HasForeignKey(m => m.SenderID);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany(u => u.ReceivedMessages)
                .HasForeignKey(m => m.ReceiverID);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Reviewer)
                .WithMany(u => u.ReviewsGiven)
                .HasForeignKey(r => r.ReviewerID);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Reviewee)
                .WithMany(u => u.ReviewsReceived)
                .HasForeignKey(r => r.RevieweeID);*/
        }
    
    }
}
