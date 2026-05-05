using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PressureInletVBC : OneOf_CustomFluidBCVelocity
{
    /// <summary>Schema name: PressureInletVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE_INLET_VELOCITY";

}
