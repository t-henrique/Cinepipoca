using System;
using System.Collections.Generic;
using System.Text;

namespace Cinepipoca.Models
{
    public class Movie 
    {
        public int Id { get; set; }
        public string Poster_Path { get; set; }
        public Boolean Adult { get; set; }
        public string Overview { get; set; }
        public string Release_Date { get; set; }
        public string OriginalTitle { get; set; }
        public string Title { get; set; }
        public List<int> Genres { get; set; }
    }
}
