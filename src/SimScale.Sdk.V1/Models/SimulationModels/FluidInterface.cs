using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FluidInterface
{
    /// <summary>Schema name: FluidInterface</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FLUID_INTERFACE";

    [JsonPropertyName("connections")]
    public List<RegionInterface>? Connections { get; set; }

}
