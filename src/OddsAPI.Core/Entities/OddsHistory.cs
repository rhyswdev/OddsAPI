using System;

namespace OddsAPI.Core.Entities;

public class OddsHistory
{
    public Guid Id { get; set; }
    public Guid OddsId { get; set; }
    public decimal PreviousPrice { get; set; }
    public decimal NewPrice { get; set; }
    public string ChangeReason { get; set; } = string.Empty; // Scheduled update, user request, etc.
    public string? MarketContext { get; set; } // JSON string for additional market data
    public DateTime CreatedAt { get; set; }

    // Navigation property
    public virtual Odds Odds { get; set; } = null!;
} 