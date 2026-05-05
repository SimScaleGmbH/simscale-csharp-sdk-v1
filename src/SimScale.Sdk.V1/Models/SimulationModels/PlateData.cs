using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PlateData
{
    /// <summary>Free area ratio is the ratio of open area of the perforated plate to its total area.</summary>
    [JsonPropertyName("freeAreaRatio")]
    public double? FreeAreaRatio { get; set; }

    [JsonPropertyName("holeShape")]
    public OneOf_PlateDataHoleShape? HoleShape { get; set; }

}
