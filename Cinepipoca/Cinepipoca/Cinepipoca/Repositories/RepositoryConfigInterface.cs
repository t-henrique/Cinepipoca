using Cinepipoca.Configurations;
using Cinepipoca.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinepipoca.Repositories
{
    public class RepositoryConfigInterface <T> 
    {
        protected T returnRepositoryConfiguration()
        {
            return RestService.For<T>(Config.UrlBase,
                new RefitSettings
                {
                    ContentSerializer = new JsonContentSerializer(
                        new JsonSerializerSettings
                        {
                            ContractResolver = new CamelCasePropertyNamesContractResolver()
                        }
                    )
                }
            );
        }
    }
}
