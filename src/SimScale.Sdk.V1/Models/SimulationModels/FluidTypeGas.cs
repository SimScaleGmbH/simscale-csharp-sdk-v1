using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FluidTypeGas : OneOf_IncompressibleMaterialFluidType, OneOf_FluidCompressibleMaterialFluidType
{
    /// <summary>Schema name: FluidTypeGas</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GAS";

}
