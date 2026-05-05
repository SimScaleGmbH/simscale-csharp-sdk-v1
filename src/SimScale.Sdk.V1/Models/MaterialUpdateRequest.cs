using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>Material update request schema</summary>
public class MaterialUpdateRequest
{
    [JsonPropertyName("operations")]
    [JsonRequired]
    public required List<MaterialUpdateOperation> Operations { get; set; }

}
