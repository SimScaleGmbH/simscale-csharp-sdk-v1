using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class TranslateBodiesParameters
{
    /// <summary>List of solid regions and/or sheet bodies.</summary>
    [JsonPropertyName("occurrences")]
    public List<string>? Occurrences { get; set; }

    [JsonPropertyName("translation_method")]
    [JsonRequired]
    public required TranslateGroupParameter TranslationMethod { get; set; }

    /// <summary>If true, the operation creates new bodies instead of modifying the selected ones; if false, the selected bodies are m...</summary>
    [JsonPropertyName("copy_bodies")]
    [JsonRequired]
    public required bool CopyBodies { get; set; }

}
