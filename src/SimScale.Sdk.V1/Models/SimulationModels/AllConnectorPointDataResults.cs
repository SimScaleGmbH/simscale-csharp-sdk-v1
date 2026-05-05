using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AllConnectorPointDataResults : OneOf_MarcConnectorPointDataItemResults
{
    /// <summary>Schema name: AllConnectorPointDataResults</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ALL";

}
