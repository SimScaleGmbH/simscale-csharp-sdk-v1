using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcPressureResultControlItem : OneOf_MarcResultControlSolutionFields
{
    /// <summary>Schema name: MarcPressureResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pressureType")]
    public ExternalPressure? PressureType { get; set; }

}
