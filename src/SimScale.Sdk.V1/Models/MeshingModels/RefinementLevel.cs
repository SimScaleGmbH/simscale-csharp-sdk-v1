using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class RefinementLevel
{
    [JsonPropertyName("distance")]
    public Dimensional_Length? Distance { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }

}
