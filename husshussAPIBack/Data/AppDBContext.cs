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
        public DbSet<Socialmedia> socialmedia { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurer les clés étrangères et autres relations ici
             modelBuilder.Entity<Influencer>()
                .HasOne(i => i.User) // Propriété de navigation
                .WithMany(u => u.Influencers) // Collection dans User
                .HasForeignKey(i => i.UserID) // Clé étrangère dans Influencer
                .OnDelete(DeleteBehavior.Cascade); // Cascade on delete (optionnel)

        
          
          modelBuilder.Entity<Socialmedia>()
                .HasOne(s => s.Influencer) // Propriété de navigation dans Socialmedia
                .WithMany(i => i.SocialMedias) // Collection dans Influencer
                .HasForeignKey(s => s.InfluencerID) // Clé étrangère dans Socialmedia
                .OnDelete(DeleteBehavior.Cascade); // Cascade on delete

            base.OnModelCreating(modelBuilder);
        }
    
    }
}
