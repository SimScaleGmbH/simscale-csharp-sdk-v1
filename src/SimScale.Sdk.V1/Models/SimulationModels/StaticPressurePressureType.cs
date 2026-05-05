using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StaticPressurePressureType : OneOf_FieldCalculationsPressureResultControlPressureType
{
    /// <summary>Schema name: StaticPressurePressureType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STATIC_PRESSURE";

}
