using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RelativeERPFieldSelection : OneOf_ERPCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: RelativeERPFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE_ERP";

    [JsonPropertyName("referenceERPValue")]
    public Dimensional_Power? ReferenceERPValue { get; set; }

}
