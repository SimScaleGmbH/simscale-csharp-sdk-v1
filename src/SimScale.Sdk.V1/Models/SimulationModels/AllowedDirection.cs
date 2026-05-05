using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AllowedDirection : OneOf_DirectionalMaterialStructureMode
{
    /// <summary>Schema name: AllowedDirection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ALLOWED_DIRECTION";

}
