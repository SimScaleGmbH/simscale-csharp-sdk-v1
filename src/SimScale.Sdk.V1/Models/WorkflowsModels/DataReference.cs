using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Reference to a data in a workflow. It is used to wire together the workflow topology and also used in the algorithms for the workflow execution. Specific subtypes are generated for each data type for type safe wiring.</summary>
public class DataReference
{
    [JsonPropertyName("dataName")]
    public string? DataName { get; set; }

    [JsonPropertyName("dataTypeReference")]
    public string? DataTypeReference { get; set; }

    [JsonPropertyName("doc")]
    public string? Doc { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("multiLanguageDoc")]
    public Dictionary<string, string>? MultiLanguageDoc { get; set; }

    [JsonPropertyName("multiLanguageLabel")]
    public Dictionary<string, string>? MultiLanguageLabel { get; set; }

}
