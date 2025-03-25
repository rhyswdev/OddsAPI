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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Odds>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.EventId).IsRequired();
            entity.Property(e => e.MarketId).IsRequired();
            entity.Property(e => e.Selection).IsRequired();
            entity.Property(e => e.Price).HasPrecision(10, 2);
            entity.Property(e => e.Source).IsRequired();
        });
    }
} 