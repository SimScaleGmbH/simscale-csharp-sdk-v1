using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class FindInterferingBodiesResponse
{
    /// <summary>List of overlapping solid regions' pairs.</summary>
    [JsonPropertyName("body_pairs")]
    [JsonRequired]
    public required List<Interference> BodyPairs { get; set; }

}
