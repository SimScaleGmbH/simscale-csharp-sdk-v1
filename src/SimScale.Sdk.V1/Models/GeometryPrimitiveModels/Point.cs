using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.GeometryPrimitiveModels;

public class Point : GeometryPrimitive
{
    /// <summary>Schema name: Point</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "POINT";

    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("center")]
    public DimensionalVector_Length? Center { get; set; }

}
