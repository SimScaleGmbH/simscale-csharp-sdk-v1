using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactNormalStress : OneOf_MarcContactResultControlItemContactType
{
    /// <summary>Schema name: MarcContactNormalStress</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NORMAL_STRESS";

}
