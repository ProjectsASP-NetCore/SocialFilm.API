using SocialFilm.API.Watching.Domain.Models;
using SocialFilm.API.Watching.Domain.Services.Communication;

namespace SocialFilm.API.Watching.Domain.Services;

public interface ISeasonService
{
    Task<IEnumerable<Season>> ListAsync();
    Task<IEnumerable<Season>> ListBySeasonIdAsync(int seasonId);
    Task<SeasonResponse> SaveAsync(Episode season);
    Task<SeasonResponse> UpdateAsync(int seasonId, Season season);
    Task<SeasonResponse> DeleteAsync(int season);
}