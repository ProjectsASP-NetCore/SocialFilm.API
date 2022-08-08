using SocialFilm.API.Watching.Domain.Models;
using SocialFilm.API.Watching.Domain.Services.Communication;

namespace SocialFilm.API.Watching.Domain.Services;

public interface IEpisodeService
{
    Task<IEnumerable<Episode>> ListAsync();
    Task<IEnumerable<Episode>> ListByEpisodeIdAsync(int episodeId);
    Task<EpisodeResponse> SaveAsync(Episode episode);
    Task<EpisodeResponse> UpdateAsync(int episodeId, Episode episode);
    Task<EpisodeResponse> DeleteAsync(int episodeId);
}