using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RelativeHarmonicDisplacementType : OneOf_HarmonicDisplacementResultControlItemHarmonicDisplacementType
{
    /// <summary>Schema name: RelativeHarmonicDisplacementType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE";

    [JsonPropertyName("complexNumber")]
    public string? ComplexNumber { get; set; }

}
