using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class ScalarField
{
    [JsonPropertyName("fieldName")]
    [JsonRequired]
    public required string FieldName { get; set; }

    [JsonPropertyName("component")]
    public string? Component { get; set; }

    [JsonPropertyName("dataType")]
    [JsonRequired]
    public required string DataType { get; set; }

}
