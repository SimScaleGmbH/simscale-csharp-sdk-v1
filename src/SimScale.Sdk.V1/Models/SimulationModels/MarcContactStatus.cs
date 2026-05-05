using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactStatus : OneOf_MarcContactResultControlItemContactType
{
    /// <summary>Schema name: MarcContactStatus</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STATUS";

}
