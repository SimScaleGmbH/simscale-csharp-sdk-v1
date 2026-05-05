using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TurbulenceIntensityTIBC : OneOf_VelocityInletBCTurbulenceIntensity
{
    /// <summary>Schema name: TurbulenceIntensityTIBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("value")]
    public DimensionalFunction_Dimensionless? Value { get; set; }

}
