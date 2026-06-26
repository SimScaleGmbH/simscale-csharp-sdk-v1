using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Holds unit profiles for a given quantity: one for the metric system, and an optional profile for the US customary system.</summary>
public class UnitProfilesDimension
{
    [JsonPropertyName("metric")]
    public UnitProfileDimension? Metric { get; set; }

    [JsonPropertyName("usCustomary")]
    public UnitProfileDimension? UsCustomary { get; set; }

}
