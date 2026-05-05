using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticAxisDefinition : OneOf_HingeConstraintBCAxisDefinition
{
    /// <summary>Schema name: AutomaticAxisDefinition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC";

}
