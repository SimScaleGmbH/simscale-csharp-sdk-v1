using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalPBC : OneOf_CustomFluidBCPressure, OneOf_CustomFluidBCPressureRgh, OneOf_CustomFluidBCGaugePressure, OneOf_CustomFluidBCGaugePressureRgh, OneOf_PressureInletBCPressure, OneOf_PressureInletBCPressureRgh, OneOf_PressureInletBCGaugePressure
{
    /// <summary>Schema name: TotalPBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_PRESSURE";

    [JsonPropertyName("totalPressure")]
    public DimensionalFunction_Pressure? TotalPressure { get; set; }

}
