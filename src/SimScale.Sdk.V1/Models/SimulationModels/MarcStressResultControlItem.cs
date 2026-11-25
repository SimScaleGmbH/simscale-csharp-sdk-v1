using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcStressResultControlItem : OneOf_MarcResultControlSolutionFields
{
    /// <summary>Schema name: MarcStressResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRESS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("stressType")]
    public OneOf_MarcStressResultControlItemStressType? StressType { get; set; }

    /// <summary>Choose where stress and strain results are computed and stored.Nodes: Values are extrapolated from the integration po...</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

}
