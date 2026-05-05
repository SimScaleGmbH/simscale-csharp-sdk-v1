using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class FlowVolumeExtractionInternalParameters
{
    /// <summary>Seed face indicating an area adjacent to the flow.</summary>
    [JsonPropertyName("seed_face")]
    public string? SeedFace { get; set; }

    /// <summary>List of faces representing the boundary of the internal flow region. Boundary faces are needed in case the internal f...</summary>
    [JsonPropertyName("boundary_faces")]
    public List<string>? BoundaryFaces { get; set; }

    /// <summary>List of solid regions and/or sheet bodies to exclude from the flow volume.</summary>
    [JsonPropertyName("excluded_parts")]
    public List<string>? ExcludedParts { get; set; }

}
