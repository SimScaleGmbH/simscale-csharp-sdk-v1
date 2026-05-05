using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HarmonicResponseResultControlItem : OneOf_SolidResultControlPointData
{
    /// <summary>Schema name: HarmonicResponseResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HARMONIC_RESPONSE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fieldSelection")]
    public OneOf_HarmonicResponseResultControlItemFieldSelection? FieldSelection { get; set; }

    [JsonPropertyName("complexNumber")]
    public string? ComplexNumber { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
