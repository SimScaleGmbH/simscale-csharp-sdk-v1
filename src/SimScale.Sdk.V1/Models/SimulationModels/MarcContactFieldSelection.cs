using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactFieldSelection : OneOf_MarcMinMaxFieldsCalculationResultControlItemFieldSelection, OneOf_MarcAverageFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: MarcContactFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONTACT";

    [JsonPropertyName("contactType")]
    public OneOf_MarcContactFieldSelectionContactType? ContactType { get; set; }

}
