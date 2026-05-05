using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SignedVonMisesStressType : OneOf_StressFieldSelectionStressType
{
    /// <summary>Schema name: SignedVonMisesStressType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SIGNED_VON_MISES";

}
