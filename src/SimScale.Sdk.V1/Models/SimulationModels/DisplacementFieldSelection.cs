using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DisplacementFieldSelection : OneOf_HarmonicResponseResultControlItemFieldSelection, OneOf_AverageFieldsCalculationResultControlItemFieldSelection, OneOf_TemporalResponseResultControlItemFieldSelection, OneOf_MinMaxFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: DisplacementFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DISPLACEMENT";

    [JsonPropertyName("displacementType")]
    public OneOf_DisplacementFieldSelectionDisplacementType? DisplacementType { get; set; }

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

    /// <summary>This option allows to control the output frequency and accuracy:Post simulation: Point data output is synchronised wi...</summary>
    [JsonPropertyName("outputMethod")]
    public string? OutputMethod { get; set; }

}
