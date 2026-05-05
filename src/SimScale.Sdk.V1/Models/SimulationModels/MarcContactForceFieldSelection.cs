using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactForceFieldSelection : OneOf_MarcSumFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: MarcContactForceFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONTACT_FORCE";

    [JsonPropertyName("contactType")]
    public OneOf_MarcContactForceFieldSelectionContactType? ContactType { get; set; }

}
