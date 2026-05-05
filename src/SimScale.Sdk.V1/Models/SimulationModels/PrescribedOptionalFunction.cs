using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PrescribedOptionalFunction : OneOf_PartialVectorFunctionX, OneOf_PartialVectorFunctionY, OneOf_PartialVectorFunctionZ
{
    /// <summary>Schema name: PrescribedOptionalFunction</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESCRIBED";

    [JsonPropertyName("value")]
    public OneOf_PrescribedOptionalFunctionValue? Value { get; set; }

}
