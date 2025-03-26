using System;

namespace OddsAPI.Core.Entities;

public class Market
{
    public Guid Id { get; set; }
    public string EventId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Status { get; set; } = string.Empty; // Scheduled, InPlay, Completed, Cancelled
    public Guid SportId { get; set; }
    public Guid? HomeTeamId { get; set; }
    public Guid? AwayTeamId { get; set; }
    public Guid? CompetitionId { get; set; }
    public string? Venue { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }

    // Navigation properties
    public virtual Entity Sport { get; set; } = null!;
    public virtual Entity? HomeTeam { get; set; }
    public virtual Entity? AwayTeam { get; set; }
    public virtual Entity? Competition { get; set; }
    public virtual ICollection<Odds> Odds { get; set; } = new List<Odds>();
} 