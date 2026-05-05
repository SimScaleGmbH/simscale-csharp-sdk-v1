using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcStrainFieldSelection : OneOf_MarcAverageFieldsCalculationResultControlItemFieldSelection, OneOf_MarcMinMaxFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: MarcStrainFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRAIN";

    [JsonPropertyName("strainType")]
    public OneOf_MarcStrainFieldSelectionStrainType? StrainType { get; set; }

}
