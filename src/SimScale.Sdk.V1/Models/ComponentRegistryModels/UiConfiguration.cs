using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

public class UiConfiguration
{
    [JsonPropertyName("configurationEntries")]
    public List<JsonElement>? ConfigurationEntries { get; set; }

}
