using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.GeometryPrimitiveModels;

public class Box : GeometryPrimitive
{
    /// <summary>Schema name: Box</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BOX";

    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("scale")]
    public DecimalVector? Scale { get; set; }

    [JsonPropertyName("translation")]
    public DimensionalVector_Length? Translation { get; set; }

    [JsonPropertyName("rotationAxis")]
    public DimensionalVector_Length? RotationAxis { get; set; }

    [JsonPropertyName("rotationAngle")]
    public Dimensional_Angle? RotationAngle { get; set; }

}
