using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OddsAPI.Core.Entities;
using OddsAPI.Core.Interfaces;
using OddsAPI.Core.Models;
using AutoMapper;
using MassTransit;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using OddsAPI.Core.Events;

namespace OddsAPI.Application.Services;

public class OddsService : IOddsService
{
    private readonly IOddsRepository _oddsRepository;
    private readonly IMapper _mapper;
    private readonly IDistributedCache _cache;
    private readonly IPublishEndpoint _publishEndpoint;
    private readonly ILogger<OddsService> _logger;

    public OddsService(
        IOddsRepository oddsRepository,
        IMapper mapper,
        IDistributedCache cache,
        IPublishEndpoint publishEndpoint,
        ILogger<OddsService> logger)
    {
        _oddsRepository = oddsRepository;
        _mapper = mapper;
        _cache = cache;
        _publishEndpoint = publishEndpoint;
        _logger = logger;
    }

    public async Task<OddsDto> CreateAsync(CreateOddsDto createOddsDto)
    {
        try
        {
            var odds = _mapper.Map<Odds>(createOddsDto);
            odds.CreatedAt = DateTime.UtcNow;
            odds.UpdatedAt = DateTime.UtcNow;
            odds.IsActive = true;

            var createdOdds = await _oddsRepository.CreateAsync(odds);
            await InvalidateCacheAsync(createdOdds.Market.EventId);
            await PublishOddsUpdatedEventAsync(createdOdds);
            return _mapper.Map<OddsDto>(createdOdds);
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<OddsDto> GetByIdAsync(Guid id)
    {
        try
        {
            var odds = await _oddsRepository.GetByIdAsync(id);
            return _mapper.Map<OddsDto>(odds);
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<IEnumerable<OddsDto>> GetByMarketIdAsync(Guid marketId)
    {
        try
        {
            var odds = await _oddsRepository.GetByEventIdAsync(marketId.ToString());
            return _mapper.Map<IEnumerable<OddsDto>>(odds);
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<OddsDto> UpdateAsync(Guid id, UpdateOddsDto updateOddsDto)
    {
        try
        {
            var odds = await _oddsRepository.GetByIdAsync(id);
            if (odds == null)
                return null!;

            _mapper.Map(updateOddsDto, odds);
            odds.UpdatedAt = DateTime.UtcNow;

            await _oddsRepository.UpdateAsync(odds);
            await InvalidateCacheAsync(odds.Market.EventId);
            await PublishOddsUpdatedEventAsync(odds);
            return _mapper.Map<OddsDto>(odds);
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        try
        {
            var odds = await _oddsRepository.GetByIdAsync(id);
            if (odds == null)
                return false;

            await _oddsRepository.DeleteAsync(id);
            await InvalidateCacheAsync(odds.Market.EventId);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<IEnumerable<OddsDto>> GetActiveAsync()
    {
        try
        {
            var odds = await _oddsRepository.GetActiveAsync();
            return _mapper.Map<IEnumerable<OddsDto>>(odds);
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task ScheduleOddsUpdateAsync(string eventId, string marketId, TimeSpan interval)
    {
        // This will be implemented with Quartz.NET for scheduling
        _logger.LogInformation("Scheduling odds update for event {EventId}, market {MarketId} with interval {Interval}",
            eventId, marketId, interval);
    }

    private async Task CacheOddsAsync(string key, IEnumerable<Odds> odds)
    {
        var options = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
        };

        var serialized = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(odds);
        await _cache.SetAsync(key, serialized, options);
    }

    private async Task InvalidateCacheAsync(string eventId)
    {
        var cacheKey = $"odds:event:{eventId}";
        await _cache.RemoveAsync(cacheKey);
    }

    private async Task PublishOddsUpdatedEventAsync(Odds odds)
    {
        var @event = new OddsUpdatedEvent
        {
            Id = odds.Id,
            EventId = odds.Market.EventId,
            MarketId = odds.MarketId.ToString(),
            Selection = odds.Selection,
            Price = odds.Price,
            Source = odds.Source,
            UpdatedAt = odds.UpdatedAt,
            ExpiresAt = odds.ExpiresAt
        };

        await _publishEndpoint.Publish(@event);
    }

    private async Task SaveOddsHistoryAsync(Odds odds)
    {
        // TODO: Implement odds history tracking
        await Task.CompletedTask;
    }

    private bool ValidateOdds(Odds odds)
    {
        if (odds == null)
            return false;

        if (odds.MarketId == Guid.Empty)
            return false;

        if (odds.Price <= 0)
            return false;

        return true;
    }
} 