using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TemporalResponseResultControlItem : OneOf_SolidResultControlPointData
{
    /// <summary>Schema name: TemporalResponseResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TEMPORAL_RESPONSE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fieldSelection")]
    public OneOf_TemporalResponseResultControlItemFieldSelection? FieldSelection { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
