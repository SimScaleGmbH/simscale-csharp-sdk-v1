using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValueOBC : OneOf_CustomFluidBCOmegaDissipationRate
{
    /// <summary>Schema name: FixedValueOBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("value")]
    public DimensionalFunction_SpecificTurbulenceDissipationRate? Value { get; set; }

}
