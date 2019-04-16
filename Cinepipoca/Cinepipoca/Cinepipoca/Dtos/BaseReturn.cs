using Newtonsoft.Json;
using Refit;
using System.Collections.Generic;

namespace Cinepipoca.Dtos
{
    public abstract class BaseReturn <T>
    {
        public abstract List<T> results { get; set; }
        [JsonProperty("status_message")]
        public string statusMessage { get; set; }
        [JsonProperty("status_code")]
        public int statusCode { get; set; }
    }
}