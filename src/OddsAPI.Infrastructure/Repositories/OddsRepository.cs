using Microsoft.EntityFrameworkCore;
using OddsAPI.Core.Entities;
using OddsAPI.Core.Interfaces;
using OddsAPI.Infrastructure.Data;

namespace OddsAPI.Infrastructure.Repositories;

public class OddsRepository : IOddsRepository
{
    private readonly ApplicationDbContext _context;

    public OddsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Odds?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Odds
            .Include(o => o.Market)
            .FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    public async Task<IEnumerable<Odds>> GetByEventIdAsync(string eventId, CancellationToken cancellationToken = default)
    {
        return await _context.Odds
            .Include(o => o.Market)
            .Where(o => o.Market.EventId == eventId)
            .ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<Odds>> GetActiveAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Odds
            .Include(o => o.Market)
            .Where(o => o.IsActive && o.Market.IsActive)
            .ToListAsync(cancellationToken);
    }

    public async Task<Odds> CreateAsync(Odds odds, CancellationToken cancellationToken = default)
    {
        _context.Odds.Add(odds);
        await _context.SaveChangesAsync(cancellationToken);
        return odds;
    }

    public async Task<Odds> UpdateAsync(Odds odds, CancellationToken cancellationToken = default)
    {
        _context.Entry(odds).State = EntityState.Modified;
        await _context.SaveChangesAsync(cancellationToken);
        return odds;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var odds = await _context.Odds.FindAsync(new object[] { id }, cancellationToken);
        if (odds != null)
        {
            _context.Odds.Remove(odds);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
} 