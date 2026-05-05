using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AbsoluteHarmonicAccelerationType : OneOf_HarmonicAccelerationResultControlItemHarmonicAccelerationType
{
    /// <summary>Schema name: AbsoluteHarmonicAccelerationType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ABSOLUTE";

    [JsonPropertyName("complexNumber")]
    public string? ComplexNumber { get; set; }

}
