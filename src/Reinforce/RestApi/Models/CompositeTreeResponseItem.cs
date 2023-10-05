using Newtonsoft.Json;

namespace Reinforce.RestApi.Models
{
    public class CompositeTreeResponseItem
    {
        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
