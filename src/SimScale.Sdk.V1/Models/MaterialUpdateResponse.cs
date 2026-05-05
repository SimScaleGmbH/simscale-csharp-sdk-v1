using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>Material update response schema</summary>
public class MaterialUpdateResponse
{
    [JsonPropertyName("spec")]
    [JsonRequired]
    public required SimulationSpec Spec { get; set; }

    [JsonPropertyName("tables")]
    [JsonRequired]
    public required List<Table> Tables { get; set; }

}
