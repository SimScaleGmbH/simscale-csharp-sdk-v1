using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FreestreamVBC : OneOf_VelocityOutletBCVelocity, OneOf_VelocityInletBCVelocity, OneOf_CustomFluidBCVelocity
{
    /// <summary>Schema name: FreestreamVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FREESTREAM";

    [JsonPropertyName("value")]
    public DimensionalVector_Speed? Value { get; set; }

    [JsonPropertyName("ambientPressure")]
    public OneOf_FreestreamVBCAmbientPressure? AmbientPressure { get; set; }

}
