﻿namespace SocialFilm.API.Watching.Resources;

public class SaveEpisodeResource
{
    public string Title { get; set; }
    public string Synopsis { get; set; }
    
    public int CategoryId { get; set; }
    public int VideoId { get; set; }
}