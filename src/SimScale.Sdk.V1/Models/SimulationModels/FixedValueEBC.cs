using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValueEBC : OneOf_CustomFluidBCEpsilonDissipationRate
{
    /// <summary>Schema name: FixedValueEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("value")]
    public DimensionalFunction_TurbulentDissipation? Value { get; set; }

}
