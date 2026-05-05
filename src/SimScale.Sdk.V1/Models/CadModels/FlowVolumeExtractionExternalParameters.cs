using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class FlowVolumeExtractionExternalParameters
{
    [JsonPropertyName("flow_box")]
    [JsonRequired]
    public required BoxWithUnit FlowBox { get; set; }

    /// <summary>Seed face indicating an area adjacent to the flow. A seed face is needed only when the flow is unclear and could corr...</summary>
    [JsonPropertyName("seed_face")]
    public string? SeedFace { get; set; }

    /// <summary>List of solid regions and/or sheet bodies to exclude from the flow volume.</summary>
    [JsonPropertyName("excluded_parts")]
    public List<string>? ExcludedParts { get; set; }

}
