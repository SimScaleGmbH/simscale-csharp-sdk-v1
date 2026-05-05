using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RelativeHarmonicAccelerationType : OneOf_HarmonicAccelerationResultControlItemHarmonicAccelerationType
{
    /// <summary>Schema name: RelativeHarmonicAccelerationType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE";

    [JsonPropertyName("complexNumber")]
    public string? ComplexNumber { get; set; }

}
