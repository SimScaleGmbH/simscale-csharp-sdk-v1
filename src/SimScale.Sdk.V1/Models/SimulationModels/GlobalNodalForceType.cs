using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalNodalForceType : OneOf_ForceResultControlItemForceType
{
    /// <summary>Schema name: GlobalNodalForceType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NODAL";

    [JsonPropertyName("complexNumber")]
    public string? ComplexNumber { get; set; }

}
