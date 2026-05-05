using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class ParticleTrace
{
    [JsonPropertyName("seedSettings")]
    [JsonRequired]
    public required SeedSettings SeedSettings { get; set; }

    [JsonPropertyName("visualizationStyle")]
    [JsonRequired]
    public required OneOfVisualizationStyle VisualizationStyle { get; set; }

    /// <summary>If set to true, the trace will be computed both forwards and backwards from the seed points.</summary>
    [JsonPropertyName("traceBothDirections")]
    public bool TraceBothDirections { get; set; } = true;

    [JsonPropertyName("scalarField")]
    public ScalarField? ScalarField { get; set; }

    [JsonPropertyName("solidColor")]
    public Color? SolidColor { get; set; }

}
