using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RegionRefinementSimerics : OneOf_AutomaticSimericsMeshSettingsRefinements, OneOf_ManualSimericsMeshSettingsRefinements
{
    /// <summary>Schema name: RegionRefinementSimerics</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REGION_REFINEMENT_SIMERICS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("refinementCellSizeAbsolute")]
    public Dimensional_Length? RefinementCellSizeAbsolute { get; set; }

    /// <summary>This parameter defines the length scale to which the entire region enclosed by the refinement zone needs to be resolv...</summary>
    [JsonPropertyName("refinementCellSizeRelative")]
    public double? RefinementCellSizeRelative { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
