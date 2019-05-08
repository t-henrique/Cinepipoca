using Cinepipoca.Models;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinepipoca.Dtos
{
    public class MovieResults : BaseReturn<Movie>
    {
        public override List<Movie> results { get; set; }
        public int Page { get; set; }
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }
}
