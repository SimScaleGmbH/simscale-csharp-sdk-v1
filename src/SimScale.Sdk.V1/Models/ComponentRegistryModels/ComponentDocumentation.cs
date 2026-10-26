using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

public class ComponentDocumentation
{
    [JsonPropertyName("pages")]
    public List<DocumentationPage>? Pages { get; set; }

}
