using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Coil
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topology")]
    public OneOf_CoilTopology? Topology { get; set; }

    [JsonPropertyName("coilType")]
    public OneOf_CoilCoilType? CoilType { get; set; }

    [JsonPropertyName("excitation")]
    public OneOf_CoilExcitation? Excitation { get; set; }

}
