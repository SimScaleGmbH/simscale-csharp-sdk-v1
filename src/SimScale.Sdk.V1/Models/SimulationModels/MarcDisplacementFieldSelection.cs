using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcDisplacementFieldSelection : OneOf_MarcAverageFieldsCalculationResultControlItemFieldSelection, OneOf_MarcMinMaxFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: MarcDisplacementFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DISPLACEMENT";

    [JsonPropertyName("displacementType")]
    public MarcGlobalDisplacementFieldType? DisplacementType { get; set; }

}
