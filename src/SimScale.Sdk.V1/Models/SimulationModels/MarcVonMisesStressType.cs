using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcVonMisesStressType : OneOf_MarcStressFieldSelectionStressType
{
    /// <summary>Schema name: MarcVonMisesStressType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VON_MISES";

}
