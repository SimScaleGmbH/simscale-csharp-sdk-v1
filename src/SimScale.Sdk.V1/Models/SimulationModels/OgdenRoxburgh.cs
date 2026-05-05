using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OgdenRoxburgh : OneOf_PrimaryNetworkDamageModelPrimaryNetwork
{
    /// <summary>Schema name: OgdenRoxburgh</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OGDEN_ROXBURGH";

    /// <summary>This parameter (r ≥ 1) dictates the maximum magnitude of damage achievable in the Ogden-Roxburgh model. Higher values...</summary>
    [JsonPropertyName("relativeDamageExtent")]
    public double? RelativeDamageExtent { get; set; }

    [JsonPropertyName("deformationDependence")]
    public Dimensional_EnergyDensity? DeformationDependence { get; set; }

    /// <summary>A scaling factor (β ≥ 0) that adjusts the influence of the shape-changing (deviatoric) part of the strain energy on t...</summary>
    [JsonPropertyName("deviatoricStrainEnergyFactor")]
    public double? DeviatoricStrainEnergyFactor { get; set; }

}
