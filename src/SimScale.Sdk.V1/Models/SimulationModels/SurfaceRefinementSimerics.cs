using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SurfaceRefinementSimerics : OneOf_ManualSimericsMeshSettingsRefinements, OneOf_AutomaticSimericsMeshSettingsRefinements
{
    /// <summary>Schema name: SurfaceRefinementSimerics</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SURFACE_REFINEMENT_SIMERICS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("refinementCellSizeAbsolute")]
    public Dimensional_Length? RefinementCellSizeAbsolute { get; set; }

    /// <summary>This parameter defines the length scale to which the entire region enclosed by the refinement zone needs to be resolv...</summary>
    [JsonPropertyName("refinementCellSizeRelative")]
    public double? RefinementCellSizeRelative { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
