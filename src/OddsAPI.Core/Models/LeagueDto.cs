using System;
using System.Text.Json;

namespace OddsAPI.Core.Models;

public class LeagueDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Sport { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string ExternalId { get; set; } = string.Empty;
    public JsonDocument? Metadata { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }
}

public class CreateLeagueDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Sport { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string ExternalId { get; set; } = string.Empty;
    public JsonDocument? Metadata { get; set; }
}

public class UpdateLeagueDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Sport { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string ExternalId { get; set; } = string.Empty;
    public JsonDocument? Metadata { get; set; }
    public bool IsActive { get; set; }
} 