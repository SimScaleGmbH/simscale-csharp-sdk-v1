using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedElectricPotentialEBC : OneOf_WallBCElectricBoundaryCondition
{
    /// <summary>Schema name: FixedElectricPotentialEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_ELECTRIC_POTENTIAL";

    [JsonPropertyName("potentialFunction")]
    public DimensionalFunction_ElectricPotential? PotentialFunction { get; set; }

}
