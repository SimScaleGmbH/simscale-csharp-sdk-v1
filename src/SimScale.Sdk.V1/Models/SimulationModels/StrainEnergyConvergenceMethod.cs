using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StrainEnergyConvergenceMethod : OneOf_MarcNonlinearSolverSettingsConvergenceMethod
{
    /// <summary>Schema name: StrainEnergyConvergenceMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRAIN_ENERGY";

    /// <summary>The ratio of the incremental strain energy to the total strain energy. Because energy is a scalar, this criterion is...</summary>
    [JsonPropertyName("strainEnergyTolerance")]
    public double? StrainEnergyTolerance { get; set; }

}
