using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class FindSmallGapsParameters
{
    [JsonPropertyName("maximum_distance")]
    [JsonRequired]
    public required Length MaximumDistance { get; set; }

}
