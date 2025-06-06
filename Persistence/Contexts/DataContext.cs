using Microsoft.EntityFrameworkCore;
using Persistence.Entities;

namespace Persistence.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<EventEntity> Events { get; set; }
    public DbSet<PackageEntity> Packages { get; set; }
    public DbSet<EventPackageEntity> EventsPackages { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CategoryEntity>().HasData(
            new CategoryEntity { Id = 1, CategoryName = "Outdoor & Adventure" },
            new CategoryEntity { Id = 2, CategoryName = "Music" },
            new CategoryEntity { Id = 3, CategoryName = "Fashion" },
            new CategoryEntity { Id = 4, CategoryName = "Health & Wellness" },
            new CategoryEntity { Id = 5, CategoryName = "Art & Design" },
            new CategoryEntity { Id = 6, CategoryName = "Food & Culinary" },
            new CategoryEntity { Id = 7, CategoryName = "Technology" }
        );
    }
}
