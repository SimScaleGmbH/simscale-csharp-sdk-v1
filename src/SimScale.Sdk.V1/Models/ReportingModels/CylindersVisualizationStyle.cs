using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class CylindersVisualizationStyle : OneOfVisualizationStyle
{
    /// <summary>The representation to use for particle traces.</summary>
    [JsonPropertyName("representation")]
    public string Representation { get; set; } = "CYLINDERS";

}
