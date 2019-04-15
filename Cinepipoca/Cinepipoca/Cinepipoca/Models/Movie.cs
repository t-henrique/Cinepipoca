using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinepipoca.Models
{
    public class Movie 
    {
        public int Id { get; set; }

        
        [AliasAs("Poster_Path")]
        public string PosterPath { get; set; }
        
        public Boolean Adult { get; set; }
        public string Overview { get; set; }
        [AliasAs("Release_Date")]
        public string ReleaseDate { get; set; }
        public string OriginalTitle { get; set; }
        public string Title { get; set; }
        public List<int> Genres { get; set; }
    }
}
