using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CurrentOutflowEBC : OneOf_WallBCElectricBoundaryCondition
{
    /// <summary>Schema name: CurrentOutflowEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CURRENT_OUTFLOW";

    [JsonPropertyName("currentFunction")]
    public DimensionalFunction_ElectricCurrent? CurrentFunction { get; set; }

}
