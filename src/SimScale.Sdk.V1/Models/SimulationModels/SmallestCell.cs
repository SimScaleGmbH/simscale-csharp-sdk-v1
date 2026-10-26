using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SmallestCell : OneOf_PacefishAutomeshAutomaticGapClosing, OneOf_WindComfortMeshAutomaticGapClosing
{
    /// <summary>Schema name: SmallestCell</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SMALLEST_CELL_SIZE";

}
