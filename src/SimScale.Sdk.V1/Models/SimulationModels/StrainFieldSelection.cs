using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StrainFieldSelection : OneOf_TemporalResponseResultControlItemFieldSelection, OneOf_HarmonicResponseResultControlItemFieldSelection, OneOf_AverageFieldsCalculationResultControlItemFieldSelection, OneOf_MinMaxFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: StrainFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRAIN";

    [JsonPropertyName("strainType")]
    public OneOf_StrainFieldSelectionStrainType? StrainType { get; set; }

}
