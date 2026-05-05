using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Circular holes in the perforated plate.</summary>
public class CircularHoleShape : OneOf_PlateDataHoleShape
{
    /// <summary>Circular holes in the perforated plate. Schema name: CircularHoleShape</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CIRCULAR";

    [JsonPropertyName("averageHoleDiameter")]
    public Dimensional_Length? AverageHoleDiameter { get; set; }

}
