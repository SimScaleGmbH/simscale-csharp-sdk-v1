using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CadState
{
    /// <summary>Name of the CAD state.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Faults in the CAD.</summary>
    [JsonPropertyName("faults")]
    public Dictionary<string, JsonElement>? Faults { get; set; }

    /// <summary>List of saved selections in the CAD state.</summary>
    [JsonPropertyName("savedSelections")]
    public List<SavedSelection>? SavedSelections { get; set; }

    /// <summary>List of features in the CAD state.</summary>
    [JsonPropertyName("features")]
    public List<CadFeature>? Features { get; set; }

}
