using System;
using System.Text.Json;

namespace OddsAPI.Core.Models;

public class SelectionDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Odds { get; set; }
    public string Status { get; set; } = string.Empty;
    public string ExternalId { get; set; } = string.Empty;
    public JsonDocument? Metadata { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }
}

public class CreateSelectionDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Odds { get; set; }
    public string Status { get; set; } = string.Empty;
    public string ExternalId { get; set; } = string.Empty;
    public JsonDocument? Metadata { get; set; }
}

public class UpdateSelectionDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Odds { get; set; }
    public string Status { get; set; } = string.Empty;
    public string ExternalId { get; set; } = string.Empty;
    public JsonDocument? Metadata { get; set; }
    public bool IsActive { get; set; }
} 