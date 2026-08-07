using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MeanValueVBC : OneOf_CustomFluidBCVelocity, OneOf_VelocityOutletBCVelocity, OneOf_VelocityInletBCVelocity
{
    /// <summary>Schema name: MeanValueVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_MEAN";

    [JsonPropertyName("value")]
    public DimensionalVector_Speed? Value { get; set; }

}
