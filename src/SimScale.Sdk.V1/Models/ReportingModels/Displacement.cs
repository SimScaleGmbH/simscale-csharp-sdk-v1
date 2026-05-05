using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class Displacement
{
    [JsonPropertyName("field")]
    [JsonRequired]
    public required VectorField Field { get; set; }

    [JsonPropertyName("scaleFactor")]
    public double ScaleFactor { get; set; } = 1.0;

}
