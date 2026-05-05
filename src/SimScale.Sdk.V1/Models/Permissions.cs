using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class Permissions
{
    [JsonPropertyName("permissions")]
    [JsonRequired]
    public required List<Permission> PermissionsValue { get; set; }

}
