using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define the directional dependency of this property. Isotropic means directionally independent. Orthotropic means directionally dependent.</summary>
public class OrthotropicConductivity : OneOf_SolidMaterialConductivity
{
    /// <summary>Define the directional dependency of this property. Isotropic means directionally independent. Orthotropic means dire...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ORTHOTROPIC";

    [JsonPropertyName("thermalConductivityX")]
    public DimensionalFunction_ThermalConductivity? ThermalConductivityX { get; set; }

    [JsonPropertyName("thermalConductivityY")]
    public DimensionalFunction_ThermalConductivity? ThermalConductivityY { get; set; }

    [JsonPropertyName("thermalConductivityZ")]
    public DimensionalFunction_ThermalConductivity? ThermalConductivityZ { get; set; }

}
