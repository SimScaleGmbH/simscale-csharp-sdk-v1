using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class MeasureGroup
{
    /// <summary>Localization key of the section title.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    [JsonPropertyName("hintBox")]
    public BoxHint? HintBox { get; set; }

    /// <summary>Measure results of the section.</summary>
    [JsonPropertyName("measured")]
    [JsonRequired]
    public required List<MeasuredValue> Measured { get; set; }

}
