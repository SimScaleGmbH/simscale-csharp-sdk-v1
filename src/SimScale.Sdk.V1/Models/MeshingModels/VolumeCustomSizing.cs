using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class VolumeCustomSizing : OneOf_SimmetrixMeshingFluidRefinements, OneOf_SimmetrixMeshingSolidRefinements, OneOf_SimmetrixMeshingElectromagneticsRefinements
{
    /// <summary>Schema name: VolumeCustomSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VOLUME_CUSTOM_SIZING";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("customSizingModes")]
    public OneOf_VolumeCustomSizingCustomSizingModes? CustomSizingModes { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
