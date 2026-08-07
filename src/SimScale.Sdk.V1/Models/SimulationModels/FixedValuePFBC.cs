using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValuePFBC : OneOf_CustomFluidBCPhaseFraction, OneOf_VelocityOutletBCPhaseFraction
{
    /// <summary>Schema name: FixedValuePFBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("value")]
    public Dimensional_Dimensionless? Value { get; set; }

}
