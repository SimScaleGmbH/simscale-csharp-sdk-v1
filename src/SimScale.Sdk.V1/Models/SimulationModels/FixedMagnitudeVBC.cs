using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedMagnitudeVBC : OneOf_VelocityInletBCVelocity
{
    /// <summary>Schema name: FixedMagnitudeVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE_NO_EXPRESSION";

    [JsonPropertyName("value")]
    public DimensionalFunction_Speed? Value { get; set; }

}
