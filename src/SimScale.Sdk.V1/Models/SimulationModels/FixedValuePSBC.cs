using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValuePSBC : OneOf_CustomFluidBCPassiveScalars
{
    /// <summary>Schema name: FixedValuePSBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("value")]
    public Dimensional_Dimensionless? Value { get; set; }

}
