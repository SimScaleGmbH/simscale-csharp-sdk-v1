using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HydrostaticIsothermalPBC : OneOf_PressureOutletBCPressureRgh
{
    /// <summary>Schema name: HydrostaticIsothermalPBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HYDROSTATIC_ISOTHERMAL_PRESSURE";

    [JsonPropertyName("ambientStaticPressure")]
    public Dimensional_Pressure? AmbientStaticPressure { get; set; }

}
