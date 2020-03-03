
using System.Text.Json.Serialization;

namespace GNB.Infraestructure.Data
{
    public class RateJsonData
    {
        [JsonPropertyName("from")]
        public string From { get; set; }
        [JsonPropertyName("to")]
        public string To { get; set; }
        [JsonPropertyName("rate")]
        public string Rate { get; set; }
    }
}
