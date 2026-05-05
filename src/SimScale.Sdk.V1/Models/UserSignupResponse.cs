using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class UserSignupResponse
{
    [JsonPropertyName("email")]
    [JsonRequired]
    public required string Email { get; set; }

    [JsonPropertyName("userId")]
    [JsonRequired]
    public required string UserId { get; set; }

}
