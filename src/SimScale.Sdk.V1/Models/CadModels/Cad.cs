using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class Cad
{
    /// <summary>The ID of the CAD.</summary>
    [JsonPropertyName("cadId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid CadId { get; set; }

    /// <summary>The ID of the current CAD state.</summary>
    [JsonPropertyName("cadStateId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid CadStateId { get; set; }

    /// <summary>The name of the CAD.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The time when the CAD was imported.</summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

}
