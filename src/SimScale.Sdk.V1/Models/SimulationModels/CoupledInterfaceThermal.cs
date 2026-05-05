using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CoupledInterfaceThermal : OneOf_RegionInterfaceInterfaceThermal
{
    /// <summary>Schema name: CoupledInterfaceThermal</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "COUPLED";

}
