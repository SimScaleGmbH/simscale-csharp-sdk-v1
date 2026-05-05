using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.GeometryPrimitiveModels;

public class LocalHalfSpace : GeometryPrimitive
{
    /// <summary>Schema name: LocalHalfSpace</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LOCAL_HALF_SPACE";

    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("orientationReference")]
    public string? OrientationReference { get; set; }

    [JsonPropertyName("referencePoint")]
    public DimensionalVector_Length? ReferencePoint { get; set; }

    [JsonPropertyName("normal")]
    public DimensionalVector_Length? Normal { get; set; }

}
