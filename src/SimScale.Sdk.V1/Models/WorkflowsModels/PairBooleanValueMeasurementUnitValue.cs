using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class PairBooleanValueMeasurementUnitValue
{
    [JsonPropertyName("first")]
    public BooleanValue? First { get; set; }

    /// <summary>Value model for a measurement unit value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("second")]
    public JsonElement? Second { get; set; }

}
