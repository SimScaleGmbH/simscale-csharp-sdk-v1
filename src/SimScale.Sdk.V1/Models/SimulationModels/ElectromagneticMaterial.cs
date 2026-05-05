using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticMaterial
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("materialBehavior")]
    public OneOf_ElectromagneticMaterialMaterialBehavior? MaterialBehavior { get; set; }

    [JsonPropertyName("electricConductivityType")]
    public OneOf_ElectromagneticMaterialElectricConductivityType? ElectricConductivityType { get; set; }

    [JsonPropertyName("magneticPermeabilityType")]
    public OneOf_ElectromagneticMaterialMagneticPermeabilityType? MagneticPermeabilityType { get; set; }

    [JsonPropertyName("electricPermittivityType")]
    public LinearIsotropicPermittivityMethod? ElectricPermittivityType { get; set; }

    [JsonPropertyName("densityType")]
    public IsotropicDensityMethod? DensityType { get; set; }

    [JsonPropertyName("specificHeatType")]
    public IsotropicSpecificHeatMethod? SpecificHeatType { get; set; }

    [JsonPropertyName("thermalConductivity")]
    public IsotropicThermalConductivityMethod? ThermalConductivity { get; set; }

    [JsonPropertyName("dielectricStrengthType")]
    public OneOf_ElectromagneticMaterialDielectricStrengthType? DielectricStrengthType { get; set; }

    [JsonPropertyName("coreLossesType")]
    public OneOf_ElectromagneticMaterialCoreLossesType? CoreLossesType { get; set; }

    [JsonPropertyName("dielectricLossType")]
    public OneOf_ElectromagneticMaterialDielectricLossType? DielectricLossType { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("builtInMaterial")]
    public string? BuiltInMaterial { get; set; }

    [JsonPropertyName("materialLibraryReference")]
    public MaterialLibraryReference? MaterialLibraryReference { get; set; }

}
