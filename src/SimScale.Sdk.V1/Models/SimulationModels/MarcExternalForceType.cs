using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcExternalForceType : OneOf_MarcForceFieldSelectionForceType
{
    /// <summary>Schema name: MarcExternalForceType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "EXTERNAL";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
