using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AbsoluteERPFieldSelection : OneOf_ERPCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: AbsoluteERPFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ABSOLUTE_ERP";

}
