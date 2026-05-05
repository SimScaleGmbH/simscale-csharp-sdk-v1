using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IsotropicDirectionalDependency : OneOf_LinearElasticMaterialBehaviorDirectionalDependency
{
    /// <summary>Schema name: IsotropicDirectionalDependency</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC";

    [JsonPropertyName("youngsModulus")]
    public DimensionalFunction_Pressure? YoungsModulus { get; set; }

    [JsonPropertyName("poissonsRatio")]
    public OneOf_IsotropicDirectionalDependencyPoissonsRatio? PoissonsRatio { get; set; }

    [JsonPropertyName("expansionCoefficient")]
    public DimensionalFunction_ThermalExpansionRate? ExpansionCoefficient { get; set; }

    [JsonPropertyName("referenceTemperature")]
    public Dimensional_Temperature? ReferenceTemperature { get; set; }

}
