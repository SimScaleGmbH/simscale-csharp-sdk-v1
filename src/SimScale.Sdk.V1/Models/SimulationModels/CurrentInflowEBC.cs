using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CurrentInflowEBC : OneOf_WallBCElectricBoundaryCondition
{
    /// <summary>Schema name: CurrentInflowEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CURRENT_INFLOW";

    [JsonPropertyName("currentFunction")]
    public DimensionalFunction_ElectricCurrent? CurrentFunction { get; set; }

}
