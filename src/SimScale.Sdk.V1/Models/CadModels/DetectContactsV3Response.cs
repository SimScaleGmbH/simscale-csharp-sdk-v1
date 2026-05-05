using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class DetectContactsV3Response
{
    /// <summary>List of solid regions in contact with each other.</summary>
    [JsonPropertyName("regionContacts")]
    [JsonRequired]
    public required List<RegionContact> RegionContacts { get; set; }

}
