using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GNB.Infraestructure.Data
{
    public class TransactionJsonData
    {
        [JsonPropertyName("sku")]
        public string Sku { get; set; }
        [JsonPropertyName("amount")]
        public string Amount { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
