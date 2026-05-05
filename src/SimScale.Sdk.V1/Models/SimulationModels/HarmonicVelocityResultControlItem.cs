using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HarmonicVelocityResultControlItem : OneOf_SolidResultControlSolutionFields
{
    /// <summary>Schema name: HarmonicVelocityResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HARMONIC_VELOCITY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("harmonicVelocityType")]
    public OneOf_HarmonicVelocityResultControlItemHarmonicVelocityType? HarmonicVelocityType { get; set; }

}
