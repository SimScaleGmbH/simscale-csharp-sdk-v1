using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CylindricalComponentVectorFunction : OneOf_DimensionalVectorFunctionWithLCS_ForceValue, OneOf_DimensionalVectorFunctionWithLCS_TorqueValue
{
    /// <summary>Schema name: CylindricalComponentVectorFunction</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CYLINDRICAL_COMPONENTS";

    [JsonPropertyName("radial")]
    public OneOf_CylindricalComponentVectorFunctionRadial? Radial { get; set; }

    [JsonPropertyName("tangential")]
    public OneOf_CylindricalComponentVectorFunctionTangential? Tangential { get; set; }

    [JsonPropertyName("axial")]
    public OneOf_CylindricalComponentVectorFunctionAxial? Axial { get; set; }

}
