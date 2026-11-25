using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PrescribedOptionalFunction : OneOf_CylindricalComponentPartialVectorFunctionRadial, OneOf_CylindricalComponentPartialVectorFunctionTangential, OneOf_CylindricalComponentPartialVectorFunctionAxial, OneOf_CartesianComponentPartialVectorFunctionX, OneOf_CartesianComponentPartialVectorFunctionY, OneOf_CartesianComponentPartialVectorFunctionZ, OneOf_PartialVectorFunctionX, OneOf_PartialVectorFunctionY, OneOf_PartialVectorFunctionZ
{
    /// <summary>Schema name: PrescribedOptionalFunction</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESCRIBED";

    [JsonPropertyName("value")]
    public OneOf_PrescribedOptionalFunctionValue? Value { get; set; }

}
