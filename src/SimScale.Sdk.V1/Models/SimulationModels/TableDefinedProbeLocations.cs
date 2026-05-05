using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TableDefinedProbeLocations
{
    /// <summary>Schema name: TableDefinedProbeLocations</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TABULAR";

    /// <summary>The ID of the imported table.</summary>
    [JsonPropertyName("tableId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid TableId { get; set; }

}
