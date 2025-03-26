using Microsoft.EntityFrameworkCore;
using OddsAPI.Core.Entities;

namespace OddsAPI.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Odds> Odds { get; set; } = null!;
    public DbSet<OddsHistory> OddsHistory { get; set; } = null!;
    public DbSet<Entity> Entities { get; set; } = null!;
    public DbSet<EntityInterest> EntityInterests { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Odds>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.EventId).IsRequired();
            entity.Property(e => e.MarketId).IsRequired();
            entity.Property(e => e.Selection).IsRequired();
            entity.Property(e => e.Price).HasPrecision(10, 2);
            entity.Property(e => e.Source).IsRequired();
        });

        modelBuilder.Entity<OddsHistory>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.PreviousPrice).HasPrecision(10, 2);
            entity.Property(e => e.NewPrice).HasPrecision(10, 2);
            entity.Property(e => e.ChangeReason).IsRequired();
            
            entity.HasOne(e => e.Odds)
                .WithMany()
                .HasForeignKey(e => e.OddsId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Entity>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Type).IsRequired();
            
            entity.HasIndex(e => e.Type);
            entity.HasIndex(e => e.ExternalId);
        });

        modelBuilder.Entity<EntityInterest>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.UserId).IsRequired();
            entity.Property(e => e.EntityId).IsRequired();
            entity.Property(e => e.Priority).IsRequired();
            
            entity.HasOne(e => e.Entity)
                .WithMany(e => e.EntityInterests)
                .HasForeignKey(e => e.EntityId)
                .OnDelete(DeleteBehavior.Cascade);
            
            entity.HasIndex(e => e.UserId);
            entity.HasIndex(e => e.EntityId);
        });

        // Seed initial data
        EntityConfiguration.SeedInitialEntities(modelBuilder);
    }
} 