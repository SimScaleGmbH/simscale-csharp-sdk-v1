using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define the directional dependency of this property. Isotropic means directionally independent. Orthotropic means directionally dependent.</summary>
public class OrthotropicElectricConductivity : OneOf_SolidCompressibleMaterialElectricConductivityType
{
    /// <summary>Define the directional dependency of this property. Isotropic means directionally independent. Orthotropic means dire...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ORTHOTROPIC_ELECTRIC_CONDUCTIVITY";

    [JsonPropertyName("electricResistivityX")]
    public DimensionalFunction_ElectricResistivity? ElectricResistivityX { get; set; }

    [JsonPropertyName("electricResistivityY")]
    public DimensionalFunction_ElectricResistivity? ElectricResistivityY { get; set; }

    [JsonPropertyName("electricResistivityZ")]
    public DimensionalFunction_ElectricResistivity? ElectricResistivityZ { get; set; }

}
