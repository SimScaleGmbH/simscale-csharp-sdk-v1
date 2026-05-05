using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class CreateCylinderV3Parameters
{
    [JsonPropertyName("method")]
    [JsonRequired]
    public required CreateCylinderGroupParameter Method { get; set; }

}
