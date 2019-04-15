using Refit;
using System.Collections.Generic;

namespace Cinepipoca.Dtos
{
    public abstract class BaseReturn <T>
    {
        public abstract List<T> results { get; set; }
        [AliasAs("status_message")]
        public string statusMessage { get; set; }
        [AliasAs("status_code")]
        public int statusCode { get; set; }
    }
}