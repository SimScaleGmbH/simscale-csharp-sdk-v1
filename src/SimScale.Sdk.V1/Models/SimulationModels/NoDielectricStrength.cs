using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NoDielectricStrength : OneOf_ElectromagneticMaterialDielectricStrengthType
{
    /// <summary>Schema name: NoDielectricStrength</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NONE";

}
