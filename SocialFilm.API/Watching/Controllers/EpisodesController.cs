using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SocialFilm.API.Shared.Extensions;
using SocialFilm.API.Watching.Domain.Models;
using SocialFilm.API.Watching.Domain.Services;
using SocialFilm.API.Watching.Resources;

namespace SocialFilm.API.Watching.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class EpisodesController:ControllerBase
{
    private readonly IEpisodeService _episodeService;
    private readonly IMapper _mapper;

    public EpisodesController(IEpisodeService episodeService, IMapper mapper)
    {
        _episodeService = episodeService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<IEnumerable<EpisodeResource>> GetAllAsync()
    {
        var episodes = await _episodeService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Episode>, IEnumerable<EpisodeResource>>(episodes);

        return resources;
    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveEpisodeResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var episode = _mapper.Map<SaveEpisodeResource, Episode>(resource);

        var result = await _episodeService.SaveAsync(episode);

        if (!result.Success)
            return BadRequest(result.Message);

        var episodeResource = _mapper.Map<Episode, EpisodeResource>(result.Resource);

        return Ok(episodeResource);
    }
}