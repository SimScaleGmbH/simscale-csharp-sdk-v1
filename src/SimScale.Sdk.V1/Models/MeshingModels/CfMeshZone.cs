using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Cell zones tag all cells inside the assigned volumes so that they can be used in the simulation setup, for example for MRF rotating zones, momentum sources or porous media. The interface resolution controls whether a zone is meshed body-fitted or collected from the cells of the surrounding region.Cell zones are only available when physics-based meshing is disabled. With physics-based meshing enabled, the zones are created automatically from the simulation setup.</summary>
public class CfMeshZone
{
    /// <summary>Cell zones tag all cells inside the assigned volumes so that they can be used in the simulation setup, for example fo...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CF_MESH_ZONE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The interface resolution controls how the boundary of the cell zone is represented in the mesh.Body-fitted: the mesh...</summary>
    [JsonPropertyName("interfaceResolution")]
    public string? InterfaceResolution { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
