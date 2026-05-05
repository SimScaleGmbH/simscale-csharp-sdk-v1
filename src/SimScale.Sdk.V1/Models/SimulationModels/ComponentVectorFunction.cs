using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ComponentVectorFunction : OneOf_DimensionalVectorFunction_SpeedValue, OneOf_DimensionalVectorFunction_LengthValue, OneOf_DimensionalVectorFunction_PressureValue, OneOf_DimensionalVectorFunction_ForceValue, OneOf_DimensionalVectorFunction_TorqueValue, OneOf_DimensionalVectorFunction_VolumeForceValue, OneOf_DimensionalVectorFunction_AccelerationValue
{
    /// <summary>Schema name: ComponentVectorFunction</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "COMPONENT";

    [JsonPropertyName("x")]
    public OneOf_ComponentVectorFunctionX? X { get; set; }

    [JsonPropertyName("y")]
    public OneOf_ComponentVectorFunctionY? Y { get; set; }

    [JsonPropertyName("z")]
    public OneOf_ComponentVectorFunctionZ? Z { get; set; }

}
