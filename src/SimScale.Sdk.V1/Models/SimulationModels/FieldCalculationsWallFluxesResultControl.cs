using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsWallFluxesResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsWallFluxesResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WALL_FLUXES";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public WallShearStressResultType? ResultType { get; set; }

}
