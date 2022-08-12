using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SocialFilm.API.Shared.Extensions;
using SocialFilm.API.Watching.Domain.Models;
using SocialFilm.API.Watching.Domain.Services;
using SocialFilm.API.Watching.Resources;
using SocialFilm.API.Watching.Services;

namespace SocialFilm.API.Watching.Controllers;

[ApiController]
[Route("api/v1/series/{serieId}/seasons")]
public class SerieSeasonsController:ControllerBase
{
    private readonly ISeasonService _seasonService;
    private readonly IMapper _mapper;

    public SerieSeasonsController(ISeasonService seasonService, IMapper mapper)
    {
        _seasonService = seasonService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<IEnumerable<SeasonResource>> GetAllSeasonsBySerieIdAsync(int serieId)
    {
        var seasons =  await _seasonService.ListBySerieIdAsync(serieId);

        var resources = _mapper.Map<IEnumerable<Season>, IEnumerable<SeasonResource>>(seasons);

        return resources;
    }
    
    [HttpPost]
    public async Task<IActionResult> PostSeasonsBySerieIdAsync([FromBody] SaveSeasonResource resource)
    {

        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var season = _mapper.Map<SaveSeasonResource, Season>(resource);

        var result = await _seasonService.SaveAsync(season);

        if (!result.Success)
            return BadRequest(result.Message);

        var seasonResource = _mapper.Map<Season, SaveSeasonResource>(result.Resource);

        return Ok(seasonResource);
    }
}