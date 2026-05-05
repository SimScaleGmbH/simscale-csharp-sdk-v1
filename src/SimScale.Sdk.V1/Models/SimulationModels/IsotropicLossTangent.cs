using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IsotropicLossTangent : OneOf_ElectromagneticMaterialDielectricLossType
{
    /// <summary>Schema name: IsotropicLossTangent</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC_LOSS_TANGENT";

    [JsonPropertyName("dielectricLossTangent")]
    public DimensionalFunction_Dimensionless? DielectricLossTangent { get; set; }

}
