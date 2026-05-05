using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IsotropicDielectricStrength : OneOf_ElectromagneticMaterialDielectricStrengthType
{
    /// <summary>Schema name: IsotropicDielectricStrength</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC";

    [JsonPropertyName("dielectricStrength")]
    public DimensionalFunction_ElectricFieldStrength? DielectricStrength { get; set; }

}
