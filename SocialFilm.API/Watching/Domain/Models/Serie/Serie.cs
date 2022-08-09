namespace SocialFilm.API.Watching.Domain.Models;

public class Serie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Synopsis { get; set; }
    
    //Relationship
    public int SeasonId { get; set; }
    public Season Season { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
    //Likes Relationship
    //Qualification Relationship
}