using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MomentFieldSelection : OneOf_SumFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: MomentFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MOMENT";

    [JsonPropertyName("momentType")]
    public OneOf_MomentFieldSelectionMomentType? MomentType { get; set; }

    [JsonPropertyName("referencePoint")]
    public DimensionalVector_Length? ReferencePoint { get; set; }

}
