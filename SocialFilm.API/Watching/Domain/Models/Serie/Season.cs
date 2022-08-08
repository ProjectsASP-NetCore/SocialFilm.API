namespace SocialFilm.API.Watching.Domain.Models;

public class Season
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Synopsis { get; set; }
    
    //Relationship
    public int EpisodeId { get; set; }
    public Episode Episode { get; set; }
    
    //Likes Relationship
    //Qualification Relationship
}