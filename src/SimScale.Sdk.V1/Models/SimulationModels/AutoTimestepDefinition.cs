using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutoTimestepDefinition : OneOf_SolidSimulationControlTimestepDefinition
{
    /// <summary>Schema name: AutoTimestepDefinition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_V27";

    [JsonPropertyName("simulationInterval")]
    public Dimensional_Time? SimulationInterval { get; set; }

    [JsonPropertyName("maximumTimestepLength")]
    public RestrictedDimensionalFunction_Time? MaximumTimestepLength { get; set; }

    [JsonPropertyName("minimumTimestepLength")]
    public Dimensional_Time? MinimumTimestepLength { get; set; }

    [JsonPropertyName("maximumResidual")]
    public double? MaximumResidual { get; set; }

    [JsonPropertyName("retimingEvent")]
    public OneOf_AutoTimestepDefinitionRetimingEvent? RetimingEvent { get; set; }

}
