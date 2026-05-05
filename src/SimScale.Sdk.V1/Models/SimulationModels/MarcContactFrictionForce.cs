using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactFrictionForce : OneOf_MarcContactResultControlItemContactType
{
    /// <summary>Schema name: MarcContactFrictionForce</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FRICTION_FORCE";

}
