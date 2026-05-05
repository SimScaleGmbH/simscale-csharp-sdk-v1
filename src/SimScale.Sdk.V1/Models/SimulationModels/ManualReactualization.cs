using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ManualReactualization : OneOf_FixedPointNonLinearityResolutionGeometryReactualization
{
    /// <summary>Schema name: ManualReactualization</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL";

    [JsonPropertyName("numIterations")]
    public int? NumIterations { get; set; }

}
