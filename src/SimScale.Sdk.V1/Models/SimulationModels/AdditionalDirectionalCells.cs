using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdditionalDirectionalCells
{
    /// <summary>Specify the number of additional cells to be added in the X-direction. Note: additional cells in the negative X direc...</summary>
    [JsonPropertyName("x")]
    [JsonRequired]
    public required int X { get; set; }

    /// <summary>Specify the number of additional cells to be added in the Y-direction. Note: additional cells in the negative Y direc...</summary>
    [JsonPropertyName("y")]
    [JsonRequired]
    public required int Y { get; set; }

    /// <summary>Specify the number of additional cells to be added in the Z-direction. Note: additional cells in the negative Z direc...</summary>
    [JsonPropertyName("z")]
    [JsonRequired]
    public required int Z { get; set; }

}
