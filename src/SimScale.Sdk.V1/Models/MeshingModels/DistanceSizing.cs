using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class DistanceSizing
{
    [JsonPropertyName("distance")]
    public Dimensional_Length? Distance { get; set; }

    [JsonPropertyName("defaultSize")]
    public Dimensional_Length? DefaultSize { get; set; }

    [JsonPropertyName("minSize")]
    public Dimensional_Length? MinSize { get; set; }

}
