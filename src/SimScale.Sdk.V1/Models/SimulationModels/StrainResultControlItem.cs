using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StrainResultControlItem : OneOf_SolidResultControlSolutionFields
{
    /// <summary>Schema name: StrainResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRAIN";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("strainType")]
    public OneOf_StrainResultControlItemStrainType? StrainType { get; set; }

}
