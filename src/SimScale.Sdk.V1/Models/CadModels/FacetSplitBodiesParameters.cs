using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class FacetSplitBodiesParameters
{
    /// <summary>Maximum split angle.</summary>
    [JsonPropertyName("angle")]
    [JsonRequired]
    public required double Angle { get; set; }

    /// <summary>List of solid regions and/or sheet bodies.</summary>
    [JsonPropertyName("occurrences")]
    public List<string>? Occurrences { get; set; }

}
