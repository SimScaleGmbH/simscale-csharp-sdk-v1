using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactNormalForce : OneOf_MarcContactResultControlItemContactType
{
    /// <summary>Schema name: MarcContactNormalForce</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NORMAL_FORCE";

}
