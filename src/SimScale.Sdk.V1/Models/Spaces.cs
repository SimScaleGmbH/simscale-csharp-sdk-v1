using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class Spaces
{
    [JsonPropertyName("personalSpaces")]
    public List<Space>? PersonalSpaces { get; set; }

    [JsonPropertyName("teamSpaces")]
    public List<Space>? TeamSpaces { get; set; }

}
