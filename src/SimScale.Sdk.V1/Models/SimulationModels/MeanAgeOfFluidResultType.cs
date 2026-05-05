using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MeanAgeOfFluidResultType
{
    /// <summary>Schema name: MeanAgeOfFluidResultType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MEAN_AGE_OF_FLUID";

}
