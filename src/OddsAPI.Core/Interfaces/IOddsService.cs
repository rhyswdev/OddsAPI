using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OddsAPI.Core.Models;

namespace OddsAPI.Core.Interfaces;

public interface IOddsService
{
    Task<OddsDto> CreateAsync(CreateOddsDto createOddsDto);
    Task<OddsDto> GetByIdAsync(Guid id);
    Task<IEnumerable<OddsDto>> GetByMarketIdAsync(Guid marketId);
    Task<OddsDto> UpdateAsync(Guid id, UpdateOddsDto updateOddsDto);
    Task<bool> DeleteAsync(Guid id);
    Task<IEnumerable<OddsDto>> GetActiveAsync();
    Task ScheduleOddsUpdateAsync(string eventId, string marketId, TimeSpan interval);
} 