using Refit;
using System.Collections.Generic;

namespace Cinepipoca.Dtos
{
    public abstract class BaseReturn <T>
    {
        public abstract List<T> results { get; set; }
        public int Page { get; set; }
        [AliasAs("total_results")]
        public int TotalResults { get; set; }
        [AliasAs("total_pages")]
        public int TotalPages { get; set; }
    }
}