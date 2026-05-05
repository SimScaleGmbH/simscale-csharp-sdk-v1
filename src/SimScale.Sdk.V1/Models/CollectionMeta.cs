using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CollectionMeta
{
    /// <summary>Total number of resources in the collection.</summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

}
