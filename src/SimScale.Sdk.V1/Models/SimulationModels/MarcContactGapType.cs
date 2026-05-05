using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactGapType : OneOf_MarcContactFieldSelectionContactType
{
    /// <summary>Schema name: MarcContactGapType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GAP";

}
