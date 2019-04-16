using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinepipoca.Models
{
    public class Movie 
    {
        public int Id { get; set; }

        
        [JsonProperty("Poster_Path")]
        public string PosterPath { get; set; }
        
        public Boolean Adult { get; set; }
        public string Overview { get; set; }
        [JsonProperty("Release_Date")]
        public string ReleaseDate { get; set; }
        public string OriginalTitle { get; set; }
        public string Title { get; set; }
        public List<int> Genres { get; set; }
    }
}
