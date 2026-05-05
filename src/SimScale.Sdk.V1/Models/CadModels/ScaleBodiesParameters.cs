using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class ScaleBodiesParameters
{
    /// <summary>Scaling factor.</summary>
    [JsonPropertyName("factor")]
    [JsonRequired]
    public required double Factor { get; set; }

    /// <summary>List of solid regions and/or sheet bodies.</summary>
    [JsonPropertyName("occurrences")]
    public List<string>? Occurrences { get; set; }

}
