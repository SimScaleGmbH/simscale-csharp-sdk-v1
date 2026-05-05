using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ComfortCriterionDefinitionV2
{
    [JsonPropertyName("windSpeedThresholds")]
    public DimensionalFunction_Speed? WindSpeedThresholds { get; set; }

}
