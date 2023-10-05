using System.Collections.Generic;
using Newtonsoft.Json;

namespace Reinforce.RestApi.Models
{
    public class CompositeTreeResponse
    {
        [JsonProperty("hasErrors")]
        public bool? HasErrors {  get; set; }

        [JsonProperty("results")]
        public IEnumerable<CompositeTreeResponseItem> Results { get; set; }
    }
}
