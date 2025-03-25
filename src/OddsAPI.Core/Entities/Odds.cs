namespace OddsAPI.Core.Entities;

public class Odds
{
    public Guid Id { get; set; }
    public string EventId { get; set; } = string.Empty;
    public string MarketId { get; set; } = string.Empty;
    public string Selection { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Source { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? ExpiresAt { get; set; }
    public bool IsActive { get; set; }
} 