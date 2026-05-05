using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ERPDensityResultControlItem : OneOf_SolidResultControlSolutionFields
{
    /// <summary>Schema name: ERPDensityResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ERP_DENSITY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("densityType")]
    public EquivalentRadiatedPowerDensityType? DensityType { get; set; }

}
