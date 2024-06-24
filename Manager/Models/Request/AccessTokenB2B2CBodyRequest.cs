
using System.Text.Json.Serialization;

namespace Manager.Models.Request
{
    public class AccessTokenB2B2CBodyRequest<T>
    {
        [JsonPropertyName("grantType")]
        public string? GrantType { get; set; }

        [JsonPropertyName("authCode")]
        public string? AuthCode { get; set; }

        [JsonPropertyName("refreshToken")]
        public string? RefreshToken { get; set; }

        [JsonPropertyName("additionalInfo")]
        public T? AdditionalInfo { get; set; }
    }
}
