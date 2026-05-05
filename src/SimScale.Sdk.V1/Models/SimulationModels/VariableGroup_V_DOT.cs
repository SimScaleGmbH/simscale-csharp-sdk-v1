using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VariableGroup_V_DOT
{
    [JsonPropertyName("V_DOT")]
    public Unit_VolumetricFlowRate? VDot { get; set; }

}
