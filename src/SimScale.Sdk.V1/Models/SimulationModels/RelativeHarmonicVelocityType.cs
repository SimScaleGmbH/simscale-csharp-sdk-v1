using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RelativeHarmonicVelocityType : OneOf_HarmonicVelocityResultControlItemHarmonicVelocityType
{
    /// <summary>Schema name: RelativeHarmonicVelocityType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE";

    [JsonPropertyName("complexNumber")]
    public string? ComplexNumber { get; set; }

}
