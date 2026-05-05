using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class Resolution
{
    /// <summary>Specify the number of cells in x direction for the base mesh.</summary>
    [JsonPropertyName("x")]
    [JsonRequired]
    public required int X { get; set; }

    /// <summary>Specify the number of cells in y direction for the base mesh.</summary>
    [JsonPropertyName("y")]
    [JsonRequired]
    public required int Y { get; set; }

    /// <summary>Specify the number of cells in z direction for the base mesh.</summary>
    [JsonPropertyName("z")]
    [JsonRequired]
    public required int Z { get; set; }

}
