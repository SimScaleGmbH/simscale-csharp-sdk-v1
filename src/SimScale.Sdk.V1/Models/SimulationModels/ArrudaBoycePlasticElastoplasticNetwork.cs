using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ArrudaBoycePlasticElastoplasticNetwork : OneOf_ElastoplasticNetworkPlasticityModelElastoplasticNetwork
{
    /// <summary>Schema name: ArrudaBoycePlasticElastoplasticNetwork</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ARRUDA_BOYCE_PLASTIC";

    [JsonPropertyName("nkTheta")]
    public Dimensional_Pressure? NkTheta { get; set; }

    /// <summary>Defined by the number of statistically independent links (N) in a polymer chain, this determines the material's exten...</summary>
    [JsonPropertyName("chainLength")]
    public double? ChainLength { get; set; }

    [JsonPropertyName("yieldStress")]
    public Dimensional_Pressure? YieldStress { get; set; }

    [JsonPropertyName("tangentModulus")]
    public Dimensional_Pressure? TangentModulus { get; set; }

    /// <summary>This value (from 0 to 1) defines the weight of the kinematic component relative to the isotropic component for the co...</summary>
    [JsonPropertyName("kinematicFraction")]
    public double? KinematicFraction { get; set; }

}
