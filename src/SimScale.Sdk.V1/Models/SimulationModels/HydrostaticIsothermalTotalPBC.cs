using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HydrostaticIsothermalTotalPBC : OneOf_PressureInletBCPressureRgh, OneOf_NaturalConvectionInletOutletBCPressureRgh
{
    /// <summary>Schema name: HydrostaticIsothermalTotalPBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HYDROSTATIC_ISOTHERMAL_TOTAL_PRESSURE";

    [JsonPropertyName("ambientPressure")]
    public Dimensional_Pressure? AmbientPressure { get; set; }

}
