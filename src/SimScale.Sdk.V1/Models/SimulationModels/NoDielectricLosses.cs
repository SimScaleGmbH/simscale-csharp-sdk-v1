using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NoDielectricLosses : OneOf_ElectromagneticMaterialDielectricLossType
{
    /// <summary>Schema name: NoDielectricLosses</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NONE";

}
