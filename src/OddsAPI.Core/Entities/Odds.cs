using System;

namespace OddsAPI.Core.Entities;

public class Odds
{
    public Guid Id { get; set; }
    public Guid MarketId { get; set; }
    public string MarketType { get; set; } = string.Empty; // Match Winner, Over/Under, etc.
    public string Selection { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Source { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? ExpiresAt { get; set; }
    public bool IsActive { get; set; }

    // Navigation property
    public virtual Market Market { get; set; } = null!;
} 