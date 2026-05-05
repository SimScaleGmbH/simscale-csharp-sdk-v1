using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class SurfaceCustomSizing : OneOf_SimmetrixMeshingSolidRefinements, OneOf_SimmetrixMeshingFluidRefinements, OneOf_SimmetrixMeshingElectromagneticsRefinements
{
    /// <summary>Schema name: SurfaceCustomSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SURFACE_CUSTOM_SIZING";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sizing")]
    public OneOf_SurfaceCustomSizingSizing? Sizing { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
