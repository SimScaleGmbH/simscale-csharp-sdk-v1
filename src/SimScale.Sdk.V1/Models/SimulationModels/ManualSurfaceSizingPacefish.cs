using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ManualSurfaceSizingPacefish : OneOf_NewSurfaceRefinementPacefishV38MeshSizing
{
    /// <summary>Schema name: ManualSurfaceSizingPacefish</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL_SURFACE_PACEFISH";

    [JsonPropertyName("targetResolution")]
    public Dimensional_Length? TargetResolution { get; set; }

    /// <summary>Specify the minimum number of buffer cells between regions of different refinements.</summary>
    [JsonPropertyName("bufferCellsNoExtrude")]
    public int? BufferCellsNoExtrude { get; set; }

    [JsonPropertyName("additionalDirectionalCells")]
    public AdditionalDirectionalCells? AdditionalDirectionalCells { get; set; }

}
