using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ContactFieldSelection : OneOf_TemporalResponseResultControlItemFieldSelection, OneOf_AverageFieldsCalculationResultControlItemFieldSelection, OneOf_MinMaxFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: ContactFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONTACT";

    [JsonPropertyName("contactType")]
    public OneOf_ContactFieldSelectionContactType? ContactType { get; set; }

}
