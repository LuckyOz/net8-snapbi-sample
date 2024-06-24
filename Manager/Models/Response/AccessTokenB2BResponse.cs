
using System.Text.Json.Serialization;

namespace Manager.Models.Response
{
    public class AccessTokenB2BResponse<T>
    {
        [JsonPropertyName("responseCode")]
        public string? ResponseCode { get; set; }

        [JsonPropertyName("responseMessage")]
        public string? ResponseMessage { get; set; }

        [JsonPropertyName("accessToken")]
        public string? AccessToken { get; set; }

        [JsonPropertyName("tokenType")]
        public string? TokenType { get; set; }

        [JsonPropertyName("expiresIn")]
        public string? ExpiresIn { get; set; }

        [JsonPropertyName("additionalInfo")]
        public T? AdditionalInfo { get; set; }
    }
}
