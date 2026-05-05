using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class InletOutletPSBC : OneOf_CustomFluidBCPassiveScalars
{
    /// <summary>Schema name: InletOutletPSBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INLET_OUTLET";

    [JsonPropertyName("value")]
    public Dimensional_Dimensionless? Value { get; set; }

}
