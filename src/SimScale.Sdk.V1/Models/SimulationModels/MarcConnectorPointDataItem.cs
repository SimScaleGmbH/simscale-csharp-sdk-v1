using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcConnectorPointDataItem
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("results")]
    public OneOf_MarcConnectorPointDataItemResults? Results { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
