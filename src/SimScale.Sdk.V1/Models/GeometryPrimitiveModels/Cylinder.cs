using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.GeometryPrimitiveModels;

public class Cylinder : GeometryPrimitive
{
    /// <summary>Schema name: Cylinder</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CYLINDER";

    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("reference")]
    public DimensionalVector_Length? Reference { get; set; }

    [JsonPropertyName("axis")]
    public DimensionalVector_Length? Axis { get; set; }

    [JsonPropertyName("radius")]
    public Dimensional_Length? Radius { get; set; }

}
