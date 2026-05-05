using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define the directional dependency of this property. Isotropic means directionally independent. Orthotropic means directionally dependent.</summary>
public class IsotropicElectricConductivity : OneOf_SolidCompressibleMaterialElectricConductivityType
{
    /// <summary>Define the directional dependency of this property. Isotropic means directionally independent. Orthotropic means dire...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC_ELECTRIC_CONDUCTIVITY";

    [JsonPropertyName("electricResistivityFunction")]
    public DimensionalFunction_ElectricResistivity? ElectricResistivityFunction { get; set; }

}
