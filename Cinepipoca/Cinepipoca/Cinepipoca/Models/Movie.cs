using Cinepipoca.Configurations;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cinepipoca.Models
{
    public class Movie 
    {
        public int Id { get; set; }

        private string _posterPath;
        [JsonProperty("Poster_Path")]
        public string PosterPath
        {
            get => String.Concat(Config.ImageUrlBase, _posterPath);
            set => _posterPath = value;
        }
        
        public Boolean Adult { get; set; }
        public string Overview { get; set; }

        [JsonProperty("Release_Date")]
        public DateTime ReleaseDate { get; set; }


        public string OriginalTitle { get; set; }
        public string Title { get; set; }
        public List<int> Genres { get; set; }
    }
}
