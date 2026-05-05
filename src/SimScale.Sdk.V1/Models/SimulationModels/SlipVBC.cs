using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SlipVBC : OneOf_CustomFluidBCVelocity, OneOf_WallBCVelocity
{
    /// <summary>Schema name: SlipVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SLIP";

}
