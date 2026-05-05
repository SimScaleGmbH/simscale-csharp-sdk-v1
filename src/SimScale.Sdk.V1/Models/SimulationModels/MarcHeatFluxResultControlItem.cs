using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcHeatFluxResultControlItem : OneOf_MarcResultControlSolutionFields
{
    /// <summary>Schema name: MarcHeatFluxResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HEAT_FLUX";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

}
