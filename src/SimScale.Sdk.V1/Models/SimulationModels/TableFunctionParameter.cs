using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TableFunctionParameter
{
    /// <summary>Indicates which column of the table contains the values of this independent variable. One-based indexing must be used...</summary>
    [JsonPropertyName("reference")]
    [JsonRequired]
    public required int Reference { get; set; }

    /// <summary>The name of the independent variable. Possible values: 'X', 'Y', 'Z', 'HEIGHT', 'Temperature', 'T' (time), 'Q' (mass...</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

}
