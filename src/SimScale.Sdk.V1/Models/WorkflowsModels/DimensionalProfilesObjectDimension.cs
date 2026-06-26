using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Holds dimensional profiles for a given quantity: one for the metric system, and an optional profile for the US customary system.</summary>
public class DimensionalProfilesObjectDimension
{
    [JsonPropertyName("metric")]
    public DimensionalProfileObjectDimension? Metric { get; set; }

    [JsonPropertyName("usCustomary")]
    public DimensionalProfileObjectDimension? UsCustomary { get; set; }

}
