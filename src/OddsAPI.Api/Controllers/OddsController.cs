using Microsoft.AspNetCore.Mvc;
using OddsAPI.Core.Interfaces;
using OddsAPI.Core.Models;
using Prometheus;

namespace OddsAPI.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OddsController : ControllerBase
{
    private readonly IOddsService _oddsService;
    private readonly ILogger<OddsController> _logger;
    private static readonly Counter OddsRequests = Metrics
        .CreateCounter("odds_requests_total", "Total number of odds requests");

    public OddsController(IOddsService oddsService, ILogger<OddsController> logger)
    {
        _oddsService = oddsService;
        _logger = logger;
    }

    [HttpPost]
    public async Task<ActionResult<OddsDto>> CreateOdds([FromBody] CreateOddsDto createOddsDto)
    {
        OddsRequests.Inc();
        var created = await _oddsService.CreateAsync(createOddsDto);
        return CreatedAtAction(nameof(GetOdds), new { id = created.Id }, created);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<OddsDto>> GetOdds(Guid id)
    {
        OddsRequests.Inc();
        var odds = await _oddsService.GetByIdAsync(id);
        if (odds == null)
        {
            return NotFound();
        }

        return Ok(odds);
    }

    [HttpGet("market/{marketId}")]
    public async Task<ActionResult<IEnumerable<OddsDto>>> GetOddsByMarket(Guid marketId)
    {
        OddsRequests.Inc();
        var odds = await _oddsService.GetByMarketIdAsync(marketId);
        return Ok(odds);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<OddsDto>> UpdateOdds(Guid id, [FromBody] UpdateOddsDto updateOddsDto)
    {
        OddsRequests.Inc();
        var updated = await _oddsService.UpdateAsync(id, updateOddsDto);
        if (updated == null)
        {
            return NotFound();
        }
        return Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOdds(Guid id)
    {
        OddsRequests.Inc();
        var result = await _oddsService.DeleteAsync(id);
        if (!result)
        {
            return NotFound();
        }
        return NoContent();
    }

    [HttpGet("active")]
    public async Task<ActionResult<IEnumerable<OddsDto>>> GetActiveOdds()
    {
        OddsRequests.Inc();
        var odds = await _oddsService.GetActiveAsync();
        return Ok(odds);
    }

    [HttpPost("schedule")]
    public async Task<IActionResult> ScheduleOddsUpdate(
        [FromQuery] string eventId,
        [FromQuery] string marketId,
        [FromQuery] int intervalSeconds)
    {
        OddsRequests.Inc();
        await _oddsService.ScheduleOddsUpdateAsync(
            eventId,
            marketId,
            TimeSpan.FromSeconds(intervalSeconds));

        return Ok();
    }
} 