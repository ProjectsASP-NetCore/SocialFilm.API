namespace SocialFilm.API.Watching.Domain.Models;

public class Seire
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Synopsis { get; set; }
    
    //Relationship
    public int SeasonId { get; set; }
    public Season Season { get; set; }
    
    //Categories Relationship
    //Likes Relationship
    //Qualification Relationship
}