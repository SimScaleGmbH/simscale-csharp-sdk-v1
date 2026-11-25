using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CylindricalComponentPartialVectorFunction : OneOf_DimensionalPartialVectorFunctionWithLCS_AngleValue, OneOf_DimensionalPartialVectorFunctionWithLCS_LengthValue
{
    /// <summary>Schema name: CylindricalComponentPartialVectorFunction</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CYLINDRICAL_COMPONENTS";

    [JsonPropertyName("radial")]
    public OneOf_CylindricalComponentPartialVectorFunctionRadial? Radial { get; set; }

    [JsonPropertyName("tangential")]
    public OneOf_CylindricalComponentPartialVectorFunctionTangential? Tangential { get; set; }

    [JsonPropertyName("axial")]
    public OneOf_CylindricalComponentPartialVectorFunctionAxial? Axial { get; set; }

}
