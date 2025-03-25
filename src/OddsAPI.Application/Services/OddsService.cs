using MassTransit;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using OddsAPI.Core.Entities;
using OddsAPI.Core.Events;
using OddsAPI.Core.Interfaces;

namespace OddsAPI.Application.Services;

public class OddsService : IOddsService
{
    private readonly IOddsRepository _repository;
    private readonly IDistributedCache _cache;
    private readonly IPublishEndpoint _publishEndpoint;
    private readonly ILogger<OddsService> _logger;

    public OddsService(
        IOddsRepository repository,
        IDistributedCache cache,
        IPublishEndpoint publishEndpoint,
        ILogger<OddsService> logger)
    {
        _repository = repository;
        _cache = cache;
        _publishEndpoint = publishEndpoint;
        _logger = logger;
    }

    public async Task<Odds> CreateOddsAsync(Odds odds, CancellationToken cancellationToken = default)
    {
        odds.CreatedAt = DateTime.UtcNow;
        odds.UpdatedAt = DateTime.UtcNow;
        odds.IsActive = true;

        var created = await _repository.CreateAsync(odds, cancellationToken);
        await InvalidateCacheAsync(odds.EventId, cancellationToken);
        await PublishOddsUpdatedEventAsync(created, cancellationToken);

        return created;
    }

    public async Task<Odds?> GetOddsByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _repository.GetByIdAsync(id, cancellationToken);
    }

    public async Task<IEnumerable<Odds>> GetOddsByEventIdAsync(string eventId, CancellationToken cancellationToken = default)
    {
        var cacheKey = $"odds:event:{eventId}";
        var cached = await _cache.GetAsync(cacheKey, cancellationToken);

        if (cached != null)
        {
            return System.Text.Json.JsonSerializer.Deserialize<IEnumerable<Odds>>(cached) ?? Array.Empty<Odds>();
        }

        var odds = await _repository.GetByEventIdAsync(eventId, cancellationToken);
        await CacheOddsAsync(cacheKey, odds, cancellationToken);

        return odds;
    }

    public async Task<Odds> UpdateOddsAsync(Odds odds, CancellationToken cancellationToken = default)
    {
        odds.UpdatedAt = DateTime.UtcNow;
        var updated = await _repository.UpdateAsync(odds, cancellationToken);
        await InvalidateCacheAsync(odds.EventId, cancellationToken);
        await PublishOddsUpdatedEventAsync(updated, cancellationToken);

        return updated;
    }

    public async Task DeleteOddsAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var odds = await _repository.GetByIdAsync(id, cancellationToken);
        if (odds != null)
        {
            await _repository.DeleteAsync(id, cancellationToken);
            await InvalidateCacheAsync(odds.EventId, cancellationToken);
        }
    }

    public async Task<IEnumerable<Odds>> GetActiveOddsAsync(CancellationToken cancellationToken = default)
    {
        return await _repository.GetActiveAsync(cancellationToken);
    }

    public async Task ScheduleOddsUpdateAsync(string eventId, string marketId, TimeSpan interval, CancellationToken cancellationToken = default)
    {
        // This will be implemented with Quartz.NET for scheduling
        _logger.LogInformation("Scheduling odds update for event {EventId}, market {MarketId} with interval {Interval}",
            eventId, marketId, interval);
    }

    private async Task CacheOddsAsync(string key, IEnumerable<Odds> odds, CancellationToken cancellationToken)
    {
        var options = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
        };

        var serialized = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(odds);
        await _cache.SetAsync(key, serialized, options, cancellationToken);
    }

    private async Task InvalidateCacheAsync(string eventId, CancellationToken cancellationToken)
    {
        var cacheKey = $"odds:event:{eventId}";
        await _cache.RemoveAsync(cacheKey, cancellationToken);
    }

    private async Task PublishOddsUpdatedEventAsync(Odds odds, CancellationToken cancellationToken)
    {
        var @event = new OddsUpdatedEvent
        {
            Id = odds.Id,
            EventId = odds.EventId,
            MarketId = odds.MarketId,
            Selection = odds.Selection,
            Price = odds.Price,
            Source = odds.Source,
            UpdatedAt = odds.UpdatedAt,
            ExpiresAt = odds.ExpiresAt
        };

        await _publishEndpoint.Publish(@event, cancellationToken);
    }
} 