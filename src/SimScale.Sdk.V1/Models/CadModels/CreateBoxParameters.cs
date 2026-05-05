using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class CreateBoxParameters
{
    [JsonPropertyName("method")]
    [JsonRequired]
    public required CreateBoxMethod Method { get; set; }

}
