using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WindRose
{
    [JsonPropertyName("numDirections")]
    public int? NumDirections { get; set; }

    [JsonPropertyName("velocityBuckets")]
    public List<WindRoseVelocityBucket>? VelocityBuckets { get; set; }

    [JsonPropertyName("velocityUnit")]
    public string VelocityUnit { get; set; } = "m/s";

    [JsonPropertyName("exposureCategories")]
    public List<string>? ExposureCategories { get; set; }

    [JsonPropertyName("windEngineeringStandard")]
    public string? WindEngineeringStandard { get; set; }

    [JsonPropertyName("windDataSource")]
    public string? WindDataSource { get; set; }

    [JsonPropertyName("addSurfaceRoughness")]
    public bool? AddSurfaceRoughness { get; set; }

    [JsonPropertyName("gustFactorV2")]
    public double? GustFactorV2 { get; set; }

}
