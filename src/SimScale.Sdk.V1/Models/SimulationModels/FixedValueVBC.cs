using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValueVBC : OneOf_CustomFluidBCVelocity, OneOf_VelocityOutletBCVelocity, OneOf_VelocityInletBCVelocity
{
    /// <summary>Schema name: FixedValueVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("value")]
    public DimensionalVectorFunction_Speed? Value { get; set; }

}
