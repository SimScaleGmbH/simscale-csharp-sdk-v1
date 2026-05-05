using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RestrictedTableDefinedFunction : OneOf_RestrictedDimensionalFunction_FrequencyValue, OneOf_RestrictedDimensionalFunction_TimeValue
{
    /// <summary>Schema name: RestrictedTableDefinedFunction</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RESTRICTED_TABLE_DEFINED";

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The ID of the imported table.</summary>
    [JsonPropertyName("tableId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid TableId { get; set; }

    /// <summary>Indicates which column(s) of the table contains the result values. One-based indexing must be used. For example, set...</summary>
    [JsonPropertyName("resultIndex")]
    public List<int>? ResultIndex { get; set; }

    [JsonPropertyName("independentVariables")]
    public List<TableFunctionParameter>? IndependentVariables { get; set; }

    /// <summary>Values in each row are separated by this character. Also known as a delimiter.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

}
