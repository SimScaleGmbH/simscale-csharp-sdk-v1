using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HarmonicAccelerationResultControlItem : OneOf_SolidResultControlSolutionFields
{
    /// <summary>Schema name: HarmonicAccelerationResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HARMONIC_ACCELERATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("harmonicAccelerationType")]
    public OneOf_HarmonicAccelerationResultControlItemHarmonicAccelerationType? HarmonicAccelerationType { get; set; }

}
