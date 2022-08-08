using SocialFilm.API.Shared.Domain.Model;

namespace SocialFilm.API.Watching.Domain.Models;

public class Film
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Synopsis { get; set; }
    
    //Relationship
    public int VideoId { get; set; }
    public Video Video { get; set; }
    
    //Categories Relationship
    //Likes Relationship
    //Qualification Relationship
}