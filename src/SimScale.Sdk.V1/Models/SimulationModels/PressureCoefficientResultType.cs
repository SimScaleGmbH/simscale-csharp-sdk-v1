using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PressureCoefficientResultType : OneOf_FieldCalculationsPressureResultControlResultType
{
    /// <summary>Schema name: PressureCoefficientResultType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE_COEFFICIENT";

    [JsonPropertyName("freeStreamPressure")]
    public Dimensional_Pressure? FreeStreamPressure { get; set; }

    [JsonPropertyName("freeStreamVelocity")]
    public DimensionalVector_Speed? FreeStreamVelocity { get; set; }

}
