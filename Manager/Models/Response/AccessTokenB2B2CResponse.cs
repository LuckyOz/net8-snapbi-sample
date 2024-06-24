using System.Text.Json.Serialization;

namespace Manager.Models.Response
{
    public class AccessTokenB2B2CResponse<T>
    {
        [JsonPropertyName("responseCode")]
        public string? ResponseCode { get; set; }

        [JsonPropertyName("responseMessage")]
        public string? ResponseMessage { get; set; }

        [JsonPropertyName("accessToken")]
        public string? AccessToken { get; set; }

        [JsonPropertyName("tokenType")]
        public string? TokenType { get; set; }

        [JsonPropertyName("accessTokenExpiryTime")]
        public string? AccessTokenExpiryTime { get; set; }

        [JsonPropertyName("refreshToken")]
        public string? RefreshToken { get; set; }

        [JsonPropertyName("refreshTokenExpiryTime")]
        public string? RefreshTokenExpiryTime { get; set; }

        [JsonPropertyName("additionalInfo")]
        public T? AdditionalInfo { get; set; }
    }
}
