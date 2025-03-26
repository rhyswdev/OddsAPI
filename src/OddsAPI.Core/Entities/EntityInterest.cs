using System;

namespace OddsAPI.Core.Entities;

public class EntityInterest
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid EntityId { get; set; }
    public string? Notes { get; set; }
    public string? Tags { get; set; } // Comma-separated tags
    public int Priority { get; set; } // 1-5 priority level
    public bool NotifyOnOddsChange { get; set; }
    public bool NotifyOnNewMarkets { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }

    // Navigation property
    public virtual Entity Entity { get; set; } = null!;
} 