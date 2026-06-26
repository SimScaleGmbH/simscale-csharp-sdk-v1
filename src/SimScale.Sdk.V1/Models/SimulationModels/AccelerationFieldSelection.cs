using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AccelerationFieldSelection : OneOf_HarmonicResponseResultControlItemFieldSelection, OneOf_AverageFieldsCalculationResultControlItemFieldSelection, OneOf_TemporalResponseResultControlItemFieldSelection, OneOf_MinMaxFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: AccelerationFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ACCELERATION";

    [JsonPropertyName("accelerationType")]
    public OneOf_AccelerationFieldSelectionAccelerationType? AccelerationType { get; set; }

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

    /// <summary>This option allows to control the output frequency and accuracy:Post simulation: Point data output is synchronised wi...</summary>
    [JsonPropertyName("outputMethod")]
    public string? OutputMethod { get; set; }

}
