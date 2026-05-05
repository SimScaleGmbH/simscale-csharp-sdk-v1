using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class CuttingPlane
{
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    [JsonPropertyName("center")]
    [JsonRequired]
    public required Vector3D Center { get; set; }

    [JsonPropertyName("normal")]
    [JsonRequired]
    public required Vector3D Normal { get; set; }

    [JsonPropertyName("opacity")]
    public double? Opacity { get; set; }

    [JsonPropertyName("clipping")]
    public bool Clipping { get; set; } = true;

    /// <summary>This field is required if projectVectorsOntoPlane is set to true.</summary>
    [JsonPropertyName("vectorGridSpacing")]
    public double? VectorGridSpacing { get; set; }

    [JsonPropertyName("scalarField")]
    public ScalarField? ScalarField { get; set; }

    [JsonPropertyName("vectorField")]
    public VectorField? VectorField { get; set; }

    [JsonPropertyName("solidColor")]
    public Color? SolidColor { get; set; }

    /// <summary>If a vectorField is provided, this flag will project the vector field onto the cutting plane.</summary>
    [JsonPropertyName("projectVectorsOntoPlane")]
    public bool ProjectVectorsOntoPlane { get; set; } = false;

    [JsonPropertyName("renderMode")]
    public string? RenderMode { get; set; }

}
