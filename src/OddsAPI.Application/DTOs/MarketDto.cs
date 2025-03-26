using System;

namespace OddsAPI.Application.DTOs;

public class MarketDto
{
    public Guid Id { get; set; }
    public string EventId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Status { get; set; } = string.Empty;
    public Guid SportId { get; set; }
    public Guid? HomeTeamId { get; set; }
    public Guid? AwayTeamId { get; set; }
    public Guid? CompetitionId { get; set; }
    public string? Venue { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }
    public EntityDto? Sport { get; set; }
    public EntityDto? HomeTeam { get; set; }
    public EntityDto? AwayTeam { get; set; }
    public EntityDto? Competition { get; set; }
}

public class CreateMarketDto
{
    public string EventId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Status { get; set; } = string.Empty;
    public Guid SportId { get; set; }
    public Guid? HomeTeamId { get; set; }
    public Guid? AwayTeamId { get; set; }
    public Guid? CompetitionId { get; set; }
    public string? Venue { get; set; }
}

public class UpdateMarketDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Status { get; set; } = string.Empty;
    public Guid? HomeTeamId { get; set; }
    public Guid? AwayTeamId { get; set; }
    public Guid? CompetitionId { get; set; }
    public string? Venue { get; set; }
    public bool IsActive { get; set; }
} 