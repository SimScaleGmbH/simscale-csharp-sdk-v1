using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactGap : OneOf_MarcContactResultControlItemContactType
{
    /// <summary>Schema name: MarcContactGap</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GAP";

}
