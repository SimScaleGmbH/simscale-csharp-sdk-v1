using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RegionRefinementPacefish : OneOf_PacefishMeshLegacyRefinements
{
    /// <summary>Schema name: RegionRefinementPacefish</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REGION_PACEFISH";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("targetResolution")]
    public Dimensional_Length? TargetResolution { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
