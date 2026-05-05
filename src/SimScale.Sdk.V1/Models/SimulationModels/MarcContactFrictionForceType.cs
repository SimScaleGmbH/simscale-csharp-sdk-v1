using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactFrictionForceType : OneOf_MarcContactForceFieldSelectionContactType
{
    /// <summary>Schema name: MarcContactFrictionForceType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FRICTION_FORCE";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
