using Microsoft.AspNetCore.Mvc;
using OddsAPI.Core.Entities;
using OddsAPI.Core.Interfaces;
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
    public async Task<ActionResult<Odds>> CreateOdds([FromBody] Odds odds, CancellationToken cancellationToken)
    {
        OddsRequests.Inc();
        var created = await _oddsService.CreateOddsAsync(odds, cancellationToken);
        return CreatedAtAction(nameof(GetOdds), new { id = created.Id }, created);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Odds>> GetOdds(Guid id, CancellationToken cancellationToken)
    {
        OddsRequests.Inc();
        var odds = await _oddsService.GetOddsByIdAsync(id, cancellationToken);
        if (odds == null)
        {
            return NotFound();
        }

        return Ok(odds);
    }

    [HttpGet("event/{eventId}")]
    public async Task<ActionResult<IEnumerable<Odds>>> GetOddsByEvent(string eventId, CancellationToken cancellationToken)
    {
        OddsRequests.Inc();
        var odds = await _oddsService.GetOddsByEventIdAsync(eventId, cancellationToken);
        return Ok(odds);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Odds>> UpdateOdds(Guid id, [FromBody] Odds odds, CancellationToken cancellationToken)
    {
        OddsRequests.Inc();
        if (id != odds.Id)
        {
            return BadRequest();
        }

        var updated = await _oddsService.UpdateOddsAsync(odds, cancellationToken);
        return Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOdds(Guid id, CancellationToken cancellationToken)
    {
        OddsRequests.Inc();
        await _oddsService.DeleteOddsAsync(id, cancellationToken);
        return NoContent();
    }

    [HttpGet("active")]
    public async Task<ActionResult<IEnumerable<Odds>>> GetActiveOdds(CancellationToken cancellationToken)
    {
        OddsRequests.Inc();
        var odds = await _oddsService.GetActiveOddsAsync(cancellationToken);
        return Ok(odds);
    }

    [HttpPost("schedule")]
    public async Task<IActionResult> ScheduleOddsUpdate(
        [FromQuery] string eventId,
        [FromQuery] string marketId,
        [FromQuery] int intervalSeconds,
        CancellationToken cancellationToken)
    {
        OddsRequests.Inc();
        await _oddsService.ScheduleOddsUpdateAsync(
            eventId,
            marketId,
            TimeSpan.FromSeconds(intervalSeconds),
            cancellationToken);

        return Ok();
    }
} 