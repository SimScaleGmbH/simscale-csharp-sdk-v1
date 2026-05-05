using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>Table data</summary>
public class TableData
{
    /// <summary>List of the table's columns</summary>
    [JsonPropertyName("columnLabels")]
    [JsonRequired]
    public required List<string> ColumnLabels { get; set; }

    /// <summary>Array of table rows.</summary>
    [JsonPropertyName("rows")]
    [JsonRequired]
    public required List<TableRow> Rows { get; set; }

}
