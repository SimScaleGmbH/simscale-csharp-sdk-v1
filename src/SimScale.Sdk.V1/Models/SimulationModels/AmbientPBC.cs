using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AmbientPBC : OneOf_NaturalConvectionInletOutletBCPressureRgh
{
    /// <summary>Schema name: AmbientPBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AMBIENT_PRESSURE";

    [JsonPropertyName("ambientPressure")]
    public Dimensional_Pressure? AmbientPressure { get; set; }

}
