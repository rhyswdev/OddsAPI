namespace OddsAPI.Core.Events;

public record OddsUpdatedEvent
{
    public Guid Id { get; init; }
    public string EventId { get; init; } = string.Empty;
    public string MarketId { get; init; } = string.Empty;
    public string Selection { get; init; } = string.Empty;
    public decimal Price { get; init; }
    public string Source { get; init; } = string.Empty;
    public DateTime UpdatedAt { get; init; }
    public DateTime? ExpiresAt { get; init; }
} 