using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedPowerHeatFlux : OneOf_ExternalWallHeatFluxTBCHeatFlux
{
    /// <summary>Schema name: FixedPowerHeatFlux</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_POWER";

    [JsonPropertyName("function")]
    public DimensionalFunction_Power? Function { get; set; }

}
