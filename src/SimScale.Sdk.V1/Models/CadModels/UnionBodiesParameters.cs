using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class UnionBodiesParameters
{
    /// <summary>List of solid regions and/or sheet bodies.</summary>
    [JsonPropertyName("occurrences")]
    public List<string>? Occurrences { get; set; }

    /// <summary>If `true`, faces of the resulting bodies that lie on the same underlying surface are merged. Defaults to `false`.</summary>
    [JsonPropertyName("merge_faces")]
    public bool? MergeFaces { get; set; }

}
