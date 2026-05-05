using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SolidModel
{
    [JsonPropertyName("geometricBehavior")]
    public string? GeometricBehavior { get; set; }

    [JsonPropertyName("magnitude")]
    public DimensionalFunction_Acceleration? Magnitude { get; set; }

    [JsonPropertyName("e")]
    public DimensionalVector_Length? E { get; set; }

}
