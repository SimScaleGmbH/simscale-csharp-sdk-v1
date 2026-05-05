using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcPrincipalStressType : OneOf_MarcStressFieldSelectionStressType
{
    /// <summary>Schema name: MarcPrincipalStressType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRINCIPAL";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
