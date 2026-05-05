using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class SpaceSettings
{
    [JsonPropertyName("sharingControl")]
    [JsonRequired]
    public required string SharingControl { get; set; }

}
