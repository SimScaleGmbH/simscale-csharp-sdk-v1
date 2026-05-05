using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class MeasureEntitiesParameters
{
    /// <summary>Unit of measurement.</summary>
    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

    /// <summary>List of topological entities.</summary>
    [JsonPropertyName("entities")]
    [JsonRequired]
    public required List<string> Entities { get; set; }

}
