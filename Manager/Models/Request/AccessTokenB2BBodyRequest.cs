
using System.Text.Json.Serialization;

namespace Manager.Models.Request
{
    public class AccessTokenB2BBodyRequest<T>
    {
        [JsonPropertyName("grantType")]
        public string? GrantType { get; set; }

        [JsonPropertyName("additionalInfo")]
        public T? AdditionalInfo { get; set; }
    }
}
