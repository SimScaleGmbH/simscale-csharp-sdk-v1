using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NodalForceType : OneOf_ForceFieldSelectionForceType
{
    /// <summary>Schema name: NodalForceType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NODAL";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
