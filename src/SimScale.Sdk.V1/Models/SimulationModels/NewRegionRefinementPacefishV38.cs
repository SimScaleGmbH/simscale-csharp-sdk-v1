using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NewRegionRefinementPacefishV38 : OneOf_PacefishAutomeshRefinements
{
    /// <summary>Schema name: NewRegionRefinementPacefishV38</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REGION_PACEFISH_V38";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("meshSizing")]
    public OneOf_NewRegionRefinementPacefishV38MeshSizing? MeshSizing { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
