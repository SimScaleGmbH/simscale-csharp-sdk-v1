using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MaterialLibraryReference
{
    [JsonPropertyName("materialGroupId")]
    public string? MaterialGroupId { get; set; }

    [JsonPropertyName("materialId")]
    public string? MaterialId { get; set; }

    [JsonPropertyName("interpolationParameters")]
    public Dictionary<string, InterpolationParameter>? InterpolationParameters { get; set; }

}
