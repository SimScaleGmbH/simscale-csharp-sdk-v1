using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class BlockedDirection : OneOf_DirectionalMaterialStructureMode
{
    /// <summary>Schema name: BlockedDirection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BLOCKED_DIRECTION";

}
