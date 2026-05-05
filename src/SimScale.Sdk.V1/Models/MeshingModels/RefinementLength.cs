using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class RefinementLength
{
    [JsonPropertyName("distance")]
    public Dimensional_Length? Distance { get; set; }

    [JsonPropertyName("length")]
    public Dimensional_Length? Length { get; set; }

}
