using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HarmonicDisplacementResultControlItem : OneOf_SolidResultControlSolutionFields
{
    /// <summary>Schema name: HarmonicDisplacementResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HARMONIC_DISPLACEMENT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("harmonicDisplacementType")]
    public OneOf_HarmonicDisplacementResultControlItemHarmonicDisplacementType? HarmonicDisplacementType { get; set; }

}
