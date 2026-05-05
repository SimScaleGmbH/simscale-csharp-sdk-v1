using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StressResultControlItem : OneOf_SolidResultControlSolutionFields
{
    /// <summary>Schema name: StressResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRESS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("stressType")]
    public OneOf_StressResultControlItemStressType? StressType { get; set; }

}
