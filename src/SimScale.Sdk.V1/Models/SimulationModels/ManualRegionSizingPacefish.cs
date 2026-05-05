using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ManualRegionSizingPacefish : OneOf_NewRegionRefinementPacefishV38MeshSizing
{
    /// <summary>Schema name: ManualRegionSizingPacefish</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL_REGION_PACEFISH";

    [JsonPropertyName("targetResolution")]
    public Dimensional_Length? TargetResolution { get; set; }

}
