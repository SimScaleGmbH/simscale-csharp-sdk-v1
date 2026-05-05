using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.GeometryPrimitiveModels;

public class LocalSphere : GeometryPrimitive
{
    /// <summary>Schema name: LocalSphere</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LOCAL_SPHERE";

    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("orientationReference")]
    public string? OrientationReference { get; set; }

    [JsonPropertyName("center")]
    public DimensionalVector_Length? Center { get; set; }

    [JsonPropertyName("radius")]
    public Dimensional_Length? Radius { get; set; }

}
