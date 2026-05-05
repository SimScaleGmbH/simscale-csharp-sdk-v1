using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class User
{
    [JsonPropertyName("email")]
    [JsonRequired]
    public required string Email { get; set; }

    [JsonPropertyName("userId")]
    [JsonRequired]
    public required string UserId { get; set; }

    [JsonPropertyName("firstname")]
    [JsonRequired]
    public required string Firstname { get; set; }

    [JsonPropertyName("lastname")]
    [JsonRequired]
    public required string Lastname { get; set; }

}
