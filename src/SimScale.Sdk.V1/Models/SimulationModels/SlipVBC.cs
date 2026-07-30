using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SlipVBC : OneOf_WallBCVelocity, OneOf_CustomFluidBCVelocity
{
    /// <summary>Schema name: SlipVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SLIP";

}
