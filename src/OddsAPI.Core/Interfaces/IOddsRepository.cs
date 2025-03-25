using OddsAPI.Core.Entities;

namespace OddsAPI.Core.Interfaces;

public interface IOddsRepository
{
    Task<Odds?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<Odds>> GetByEventIdAsync(string eventId, CancellationToken cancellationToken = default);
    Task<Odds> CreateAsync(Odds odds, CancellationToken cancellationToken = default);
    Task<Odds> UpdateAsync(Odds odds, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<Odds>> GetActiveAsync(CancellationToken cancellationToken = default);
} 