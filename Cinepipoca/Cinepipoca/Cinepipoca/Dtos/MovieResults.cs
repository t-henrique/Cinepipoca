using Cinepipoca.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinepipoca.Dtos
{
    public class MovieResults : BaseReturn<Movie>
    {
        public override List<Movie> results { get; set; }
    }
}
