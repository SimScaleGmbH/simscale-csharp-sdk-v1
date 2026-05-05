using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VonMisesStressType : OneOf_StressFieldSelectionStressType
{
    /// <summary>Schema name: VonMisesStressType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VON_MISES";

}
