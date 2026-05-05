using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.GeometryPrimitiveModels;

public class CartesianBox : GeometryPrimitive
{
    /// <summary>Schema name: CartesianBox</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CARTESIAN_BOX";

    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("min")]
    public DimensionalVector_Length? Min { get; set; }

    [JsonPropertyName("max")]
    public DimensionalVector_Length? Max { get; set; }

}
