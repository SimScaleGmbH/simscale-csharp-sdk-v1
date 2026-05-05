using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Region : OneOf_PacefishAutomeshPrimaryTopology
{
    /// <summary>Schema name: Region</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REGION";

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
