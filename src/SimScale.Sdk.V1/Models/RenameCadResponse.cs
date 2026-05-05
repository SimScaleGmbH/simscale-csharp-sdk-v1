using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class RenameCadResponse
{
    /// <summary>ID of the newly created CAD state.</summary>
    [JsonPropertyName("cadStateId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid CadStateId { get; set; }

}
