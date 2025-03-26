using System;

namespace OddsAPI.Core.Entities;

public class Entity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty; // Sport, Team, Player, Tournament, League, Venue
    public string? Description { get; set; }
    public string? ExternalId { get; set; } // ID from external source (e.g., Betfair)
    public string? Metadata { get; set; } // JSON string for additional data
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }

    // Navigation property
    public virtual ICollection<EntityInterest> EntityInterests { get; set; } = new List<EntityInterest>();
} 