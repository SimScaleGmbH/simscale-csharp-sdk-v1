using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NormalizedDisplacementResultControlItem : OneOf_SolidResultControlSolutionFields
{
    /// <summary>Schema name: NormalizedDisplacementResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NORMALIZED_DISPLACEMENT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("displacementType")]
    public NormalizedDisplacementType? DisplacementType { get; set; }

}
