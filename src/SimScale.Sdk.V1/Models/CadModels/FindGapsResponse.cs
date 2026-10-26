using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class FindGapsResponse
{
    /// <summary>List of detected gaps in the model.</summary>
    [JsonPropertyName("gaps")]
    [JsonRequired]
    public required List<Gap> Gaps { get; set; }

}
