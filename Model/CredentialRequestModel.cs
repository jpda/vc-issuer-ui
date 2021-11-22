using System.Text.Json.Serialization;

namespace issuer.Model
{
    public class CredentialRequestModel
    {
        [JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("expiry")]
        public long Expiry { get; set; }
    }
}