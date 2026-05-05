using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>Represents an entry of an access control list</summary>
public class Permission
{
    [JsonPropertyName("scope")]
    [JsonRequired]
    public required PermissionScope Scope { get; set; }

    [JsonPropertyName("permission")]
    [JsonRequired]
    public required string PermissionValue { get; set; }

}
