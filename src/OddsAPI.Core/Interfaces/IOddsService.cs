using OddsAPI.Core.Entities;

namespace OddsAPI.Core.Interfaces;

public interface IOddsService
{
    Task<Odds> CreateOddsAsync(Odds odds, CancellationToken cancellationToken = default);
    Task<Odds?> GetOddsByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<Odds>> GetOddsByEventIdAsync(string eventId, CancellationToken cancellationToken = default);
    Task<Odds> UpdateOddsAsync(Odds odds, CancellationToken cancellationToken = default);
    Task DeleteOddsAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<Odds>> GetActiveOddsAsync(CancellationToken cancellationToken = default);
    Task ScheduleOddsUpdateAsync(string eventId, string marketId, TimeSpan interval, CancellationToken cancellationToken = default);
} 