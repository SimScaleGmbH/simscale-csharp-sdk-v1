using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OrthotropicDirectionalDependency : OneOf_LinearElasticMaterialBehaviorDirectionalDependency
{
    /// <summary>Schema name: OrthotropicDirectionalDependency</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ORTHOTROPIC";

    [JsonPropertyName("youngsModulusX")]
    public DimensionalFunction_Pressure? YoungsModulusX { get; set; }

    [JsonPropertyName("youngsModulusY")]
    public DimensionalFunction_Pressure? YoungsModulusY { get; set; }

    [JsonPropertyName("youngsModulusZ")]
    public DimensionalFunction_Pressure? YoungsModulusZ { get; set; }

    [JsonPropertyName("poissonsRatioXY")]
    public OneOf_OrthotropicDirectionalDependencyPoissonsRatioXY? PoissonsRatioXY { get; set; }

    [JsonPropertyName("poissonsRatioYZ")]
    public OneOf_OrthotropicDirectionalDependencyPoissonsRatioYZ? PoissonsRatioYZ { get; set; }

    [JsonPropertyName("poissonsRatioXZ")]
    public OneOf_OrthotropicDirectionalDependencyPoissonsRatioXZ? PoissonsRatioXZ { get; set; }

    [JsonPropertyName("shearModulusXY")]
    public DimensionalFunction_Pressure? ShearModulusXY { get; set; }

    [JsonPropertyName("shearModulusYZ")]
    public DimensionalFunction_Pressure? ShearModulusYZ { get; set; }

    [JsonPropertyName("shearModulusXZ")]
    public DimensionalFunction_Pressure? ShearModulusXZ { get; set; }

    [JsonPropertyName("expansionCoefficientX")]
    public DimensionalFunction_ThermalExpansionRate? ExpansionCoefficientX { get; set; }

    [JsonPropertyName("expansionCoefficientY")]
    public DimensionalFunction_ThermalExpansionRate? ExpansionCoefficientY { get; set; }

    [JsonPropertyName("expansionCoefficientZ")]
    public DimensionalFunction_ThermalExpansionRate? ExpansionCoefficientZ { get; set; }

    [JsonPropertyName("referenceTemperature")]
    public Dimensional_Temperature? ReferenceTemperature { get; set; }

}
