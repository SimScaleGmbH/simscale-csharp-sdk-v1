using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CreateSavedSelectionResponse
{
    /// <summary>ID of the newly created CAD state.</summary>
    [JsonPropertyName("cadStateId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid CadStateId { get; set; }

    /// <summary>ID of the newly created saved selection.</summary>
    [JsonPropertyName("savedSelectionId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid SavedSelectionId { get; set; }

}
