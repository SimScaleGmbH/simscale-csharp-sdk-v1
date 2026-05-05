using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomComfortCriterionResultControl
{
    /// <summary>Schema name: CustomComfortCriterionResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM_COMFORT_CRITERION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("comfortCriterionDefinitionV2")]
    public ComfortCriterionDefinitionV2? ComfortCriterionDefinitionV2 { get; set; }

    /// <summary>It defines the name of the category that is reached if all defined criteria are exceeded.</summary>
    [JsonPropertyName("outOfBoundsName")]
    public string? OutOfBoundsName { get; set; }

    [JsonPropertyName("advancedSettings")]
    public AdvancedComfortCriterionSettings? AdvancedSettings { get; set; }

}
