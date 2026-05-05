using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class CloseSheetV2Parameters
{
    /// <summary>List of sheet bodies.</summary>
    [JsonPropertyName("occurrences")]
    public List<string>? Occurrences { get; set; }

    /// <summary>The `cap` healing option creates a surface to cover the existing holes. The `grow` healing option extends the faces a...</summary>
    [JsonPropertyName("heal_option")]
    [JsonRequired]
    public required string HealOption { get; set; }

}
