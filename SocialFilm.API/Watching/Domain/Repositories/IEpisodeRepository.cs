using SocialFilm.API.Watching.Domain.Models;

namespace SocialFilm.API.Watching.Domain.Repositories;

public interface IEpisodeRepository
{
    Task<IEnumerable<Episode>> ListAsync();
    Task AddAsync(Episode episode);
    Task<Episode> FindByIdAsync(int episodeId);
    Task<Episode> FindByTitleAsync(string title);
    void Update(Episode episode);
    void Remove(Episode episode);
}