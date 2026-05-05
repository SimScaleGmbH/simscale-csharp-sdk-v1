using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactFrictionStressType : OneOf_MarcContactFieldSelectionContactType
{
    /// <summary>Schema name: MarcContactFrictionStressType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FRICTION_STRESS";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
