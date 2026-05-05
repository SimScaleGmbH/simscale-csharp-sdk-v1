using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SolidCoil : OneOf_CoilCoilType
{
    /// <summary>Schema name: SolidCoil</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SOLID_COIL";

}
