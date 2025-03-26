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
    public DbSet<Market> Markets { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Market>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.EventId).IsRequired();
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Description).IsRequired();
            entity.Property(e => e.Status).IsRequired();
            entity.Property(e => e.SportId).IsRequired();
            
            entity.HasOne(e => e.Sport)
                .WithMany()
                .HasForeignKey(e => e.SportId)
                .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasOne(e => e.HomeTeam)
                .WithMany()
                .HasForeignKey(e => e.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasOne(e => e.AwayTeam)
                .WithMany()
                .HasForeignKey(e => e.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasOne(e => e.Competition)
                .WithMany()
                .HasForeignKey(e => e.CompetitionId)
                .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasIndex(e => e.EventId);
            entity.HasIndex(e => e.StartTime);
            entity.HasIndex(e => e.Status);
        });

        modelBuilder.Entity<Odds>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.MarketId).IsRequired();
            entity.Property(e => e.MarketType).IsRequired();
            entity.Property(e => e.Selection).IsRequired();
            entity.Property(e => e.Price).HasPrecision(10, 2);
            entity.Property(e => e.Source).IsRequired();
            
            entity.HasOne(e => e.Market)
                .WithMany(e => e.Odds)
                .HasForeignKey(e => e.MarketId)
                .OnDelete(DeleteBehavior.Cascade);
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