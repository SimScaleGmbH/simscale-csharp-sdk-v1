using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class CadFeatureRequest
{
    /// <summary>Available feature types: - `close_sheet_v2`: Close selected sheet bodies in order to create solid regions. - `create_...</summary>
    [JsonPropertyName("feature")]
    [JsonRequired]
    public required string Feature { get; set; }

    [JsonPropertyName("parameters")]
    public JsonElement? Parameters { get; set; }

}
