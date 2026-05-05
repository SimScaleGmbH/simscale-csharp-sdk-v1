using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedHeatFlux : OneOf_ExternalWallHeatFluxTBCHeatFlux
{
    /// <summary>Schema name: FixedHeatFlux</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED";

    [JsonPropertyName("function")]
    public DimensionalFunction_HeatFlux? Function { get; set; }

}
