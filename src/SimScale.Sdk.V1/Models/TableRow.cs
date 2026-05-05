using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class TableRow
{
    /// <summary>Values of the current row. These values are in the order specified by the `columnLabels` field.</summary>
    [JsonPropertyName("elements")]
    [JsonRequired]
    public required List<string> Elements { get; set; }

}
