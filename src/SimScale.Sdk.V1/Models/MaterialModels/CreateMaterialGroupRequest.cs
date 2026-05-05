using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MaterialModels;

public class CreateMaterialGroupRequest
{
    /// <summary>The name of the material group.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, JsonElement>? Metadata { get; set; }

    /// <summary>The material group will be assigned to this team group id. This field can only be used by support group members.</summary>
    [JsonPropertyName("teamGroupId")]
    public int? TeamGroupId { get; set; }

}
