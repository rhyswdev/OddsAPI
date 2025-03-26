using System;
using System.Text.Json;

namespace OddsAPI.Core.Models;

public class EntityDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ExternalId { get; set; } = string.Empty;
    public JsonDocument? Metadata { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }
}

public class CreateEntityDto
{
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ExternalId { get; set; } = string.Empty;
    public JsonDocument? Metadata { get; set; }
}

public class UpdateEntityDto
{
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ExternalId { get; set; } = string.Empty;
    public JsonDocument? Metadata { get; set; }
    public bool IsActive { get; set; }
} 