using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RegionRefinementWindComfort : OneOf_WindComfortMeshRefinements
{
    /// <summary>Schema name: RegionRefinementWindComfort</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REGION_REFINEMENT_WIND_COMFORT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("newFineness")]
    public OneOf_RegionRefinementWindComfortNewFineness? NewFineness { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
