using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalVonMisesStressType : OneOf_StressResultControlItemStressType
{
    /// <summary>Schema name: GlobalVonMisesStressType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VON_MISES";

    [JsonPropertyName("complexNumber")]
    public string? ComplexNumber { get; set; }

}
