using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OgdenHyperelasticModelMarc : OneOf_HyperelasticityHyperelasticModelMarc
{
    /// <summary>Schema name: OgdenHyperelasticModelMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OGDEN_MARC";

    [JsonPropertyName("numberOfTerms")]
    public OneOf_OgdenHyperelasticModelMarcNumberOfTerms? NumberOfTerms { get; set; }

    [JsonPropertyName("bulkModulus")]
    public Dimensional_Pressure? BulkModulus { get; set; }

}
