using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalPressurePressureType : OneOf_FieldCalculationsPressureResultControlPressureType
{
    /// <summary>Schema name: TotalPressurePressureType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_PRESSURE";

    [JsonPropertyName("pressureValue")]
    public Dimensional_Pressure? PressureValue { get; set; }

}
