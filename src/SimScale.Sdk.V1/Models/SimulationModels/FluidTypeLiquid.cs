using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FluidTypeLiquid : OneOf_FluidCompressibleMaterialFluidType, OneOf_IncompressibleMaterialFluidType
{
    /// <summary>Schema name: FluidTypeLiquid</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LIQUID";

}
