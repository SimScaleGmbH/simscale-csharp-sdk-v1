using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcForceFieldSelection : OneOf_MarcSumFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: MarcForceFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FORCE";

    [JsonPropertyName("forceType")]
    public OneOf_MarcForceFieldSelectionForceType? ForceType { get; set; }

}
