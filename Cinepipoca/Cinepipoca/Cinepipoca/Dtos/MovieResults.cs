using Cinepipoca.Models;
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
        [AliasAs("total_results")]
        public int TotalResults { get; set; }
        [AliasAs("total_pages")]
        public int TotalPages { get; set; }
    }
}
