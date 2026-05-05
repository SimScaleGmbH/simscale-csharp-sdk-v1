using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>Information about the user to which this permission refers</summary>
public class PermissionScope
{
    [JsonPropertyName("username")]
    [JsonRequired]
    public required string Username { get; set; }

}
