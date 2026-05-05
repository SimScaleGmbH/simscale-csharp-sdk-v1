using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticElementDefinitionMethod : OneOf_ElementTechnologyDefinitionMethod
{
    /// <summary>Schema name: AutomaticElementDefinitionMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC";

}
