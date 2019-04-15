using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinepipoca.ValueObjects
{
    public class Genres
    {
        [AliasAs("id")]
        public int Id { get; set; }
        [AliasAs("name")]
        public string Name { get; set; }
    }
}
