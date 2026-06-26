using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>(A multi-select) geometric entity assignment list.</summary>
public class EntityAssignmentList
{
    [JsonPropertyName("entities")]
    public List<string>? Entities { get; set; }

    [JsonPropertyName("savedSelections")]
    public List<string>? SavedSelections { get; set; }

    [JsonPropertyName("source")]
    public EntityAssignmentSource? Source { get; set; }

}
