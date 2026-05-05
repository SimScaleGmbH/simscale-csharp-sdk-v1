using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WriteInterval : OneOf_MarcOutputWritingContainerOutputWriting
{
    /// <summary>Schema name: WriteInterval</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WRITE_INTERVAL";

    /// <summary>Output results are saved every n time steps. Use a value larger than one to reduce the size of the output data and sp...</summary>
    [JsonPropertyName("writeInterval")]
    public int? WriteIntervalValue { get; set; }

}
