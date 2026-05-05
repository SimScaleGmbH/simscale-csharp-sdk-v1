using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class InletOutletTKEBC : OneOf_CustomFluidBCTurbulentKineticEnergy
{
    /// <summary>Schema name: InletOutletTKEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INLET_OUTLET";

    [JsonPropertyName("value")]
    public Dimensional_TurbulenceKineticEnergy? Value { get; set; }

}
