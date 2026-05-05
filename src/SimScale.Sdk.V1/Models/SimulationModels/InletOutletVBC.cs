using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class InletOutletVBC : OneOf_CustomFluidBCVelocity
{
    /// <summary>Schema name: InletOutletVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INLET_OUTLET";

    [JsonPropertyName("value")]
    public DimensionalVector_Speed? Value { get; set; }

}
