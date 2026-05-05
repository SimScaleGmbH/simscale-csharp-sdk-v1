using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define the directional dependency of this property. Isotropic means directionally independent.</summary>
public class IsotropicExpansion
{
    /// <summary>Define the directional dependency of this property. Isotropic means directionally independent. Schema name: Isotropic...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC";

    [JsonPropertyName("expansionCoefficient")]
    public DimensionalFunction_ThermalExpansionRate? ExpansionCoefficient { get; set; }

    [JsonPropertyName("referenceTemperature")]
    public Dimensional_Temperature? ReferenceTemperature { get; set; }

}
