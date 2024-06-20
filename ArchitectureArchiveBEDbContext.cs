using Microsoft.EntityFrameworkCore;
using ArchitectureArchiveBE.Models;

namespace ArchitectureArchiveBE.Data
{
    public class ArchitectureArchiveBEDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Collection> Collections { get; set; }


        public ArchitectureArchiveBEDbContext(DbContextOptions<ArchitectureArchiveBEDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(UserData.Users);
            modelBuilder.Entity<Tag>().HasData(TagData.Tags);
            modelBuilder.Entity<Style>().HasData(StyleData.Styles);
            modelBuilder.Entity<Building>().HasData(BuildingData.Buildings);
        }
    }
}
