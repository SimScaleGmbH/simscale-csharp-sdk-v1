using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This pressure formulation is suitable for atmospheric flows with perfect gas fluids: the pressure decreases with increasing height to keep the domain at hydrostatic equilibrium. The ambient pressure in the input sets the pressure at ground level.</summary>
public class HydrostaticFanPBC : OneOf_CustomFluidBCPressure, OneOf_CustomFluidBCPressureRgh, OneOf_CustomFluidBCGaugePressure, OneOf_CustomFluidBCGaugePressureRgh, OneOf_FanBCPressureRgh
{
    /// <summary>This pressure formulation is suitable for atmospheric flows with perfect gas fluids: the pressure decreases with incr...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HYDROSTATIC_ISOTHERMAL_FAN_PRESSURE";

    [JsonPropertyName("fanPressure")]
    public DimensionalFunction_Pressure? FanPressure { get; set; }

    [JsonPropertyName("environmentalTotalPressure")]
    public Dimensional_Pressure? EnvironmentalTotalPressure { get; set; }

}
