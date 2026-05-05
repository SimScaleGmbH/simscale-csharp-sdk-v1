using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalMaxOverPhaseVonMisesStressType : OneOf_StressResultControlItemStressType
{
    /// <summary>Schema name: GlobalMaxOverPhaseVonMisesStressType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MAX_OVER_PHASE_VON_MISES";

}
