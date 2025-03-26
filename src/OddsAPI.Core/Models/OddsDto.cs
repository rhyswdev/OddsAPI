using System;
using OddsAPI.Core.Entities;

namespace OddsAPI.Core.Models;

public class OddsDto
{
    public Guid Id { get; set; }
    public Guid MarketId { get; set; }
    public string MarketType { get; set; } = string.Empty;
    public string Selection { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Source { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? ExpiresAt { get; set; }
    public bool IsActive { get; set; }
    public Market? Market { get; set; }
}

public class CreateOddsDto
{
    public Guid MarketId { get; set; }
    public string MarketType { get; set; } = string.Empty;
    public string Selection { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Source { get; set; } = string.Empty;
    public DateTime? ExpiresAt { get; set; }
}

public class UpdateOddsDto
{
    public string MarketType { get; set; } = string.Empty;
    public string Selection { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Source { get; set; } = string.Empty;
    public DateTime? ExpiresAt { get; set; }
    public bool IsActive { get; set; }
} 