using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class YeohPrimaryNetwork
{
    /// <summary>Schema name: YeohPrimaryNetwork</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "YEOH_PRIMARY_NETWORK";

    [JsonPropertyName("c10Function")]
    public DimensionalFunction_Pressure? C10Function { get; set; }

    [JsonPropertyName("c20Function")]
    public DimensionalFunction_Pressure? C20Function { get; set; }

    [JsonPropertyName("c30Function")]
    public DimensionalFunction_Pressure? C30Function { get; set; }

    [JsonPropertyName("bulkModulusFunction")]
    public DimensionalFunction_Pressure? BulkModulusFunction { get; set; }

}
