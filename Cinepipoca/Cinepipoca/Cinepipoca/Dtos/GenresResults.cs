using Cinepipoca.ValueObjects;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinepipoca.Dtos
{
    public class GenresResults : BaseReturn<Genres> 
    { 
        [AliasAs("genres")]
        public List<Genres> genres { get; set; }

        public override List<Genres> results { get; set; }
    }
}
