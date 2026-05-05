using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MooneyTypeHyperelasticModelMarc : OneOf_HyperelasticityHyperelasticModelMarc
{
    /// <summary>Schema name: MooneyTypeHyperelasticModelMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MOONEY_TYPE_MARC";

    [JsonPropertyName("c10")]
    public Dimensional_Pressure? C10 { get; set; }

    [JsonPropertyName("c01")]
    public Dimensional_Pressure? C01 { get; set; }

    [JsonPropertyName("c11")]
    public Dimensional_Pressure? C11 { get; set; }

    [JsonPropertyName("c20")]
    public Dimensional_Pressure? C20 { get; set; }

    [JsonPropertyName("c30")]
    public Dimensional_Pressure? C30 { get; set; }

    [JsonPropertyName("bulkModulus")]
    public Dimensional_Pressure? BulkModulus { get; set; }

}
