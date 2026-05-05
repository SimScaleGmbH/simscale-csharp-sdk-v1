using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define the directional dependency of this property. Isotropic means directionally independent. Orthotropic means directionally dependent.</summary>
public class IsotropicConductivity : OneOf_SolidMaterialConductivity
{
    /// <summary>Define the directional dependency of this property. Isotropic means directionally independent. Orthotropic means dire...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC";

    [JsonPropertyName("thermalConductivity")]
    public DimensionalFunction_ThermalConductivity? ThermalConductivity { get; set; }

    [JsonPropertyName("thermalConductivityFunction")]
    public DimensionalFunction_ThermalConductivity? ThermalConductivityFunction { get; set; }

}
