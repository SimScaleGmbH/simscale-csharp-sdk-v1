using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticOmegaDissipation : OneOf_VelocityInletBCDissipationType
{
    /// <summary>Schema name: AutomaticOmegaDissipation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_DISSIPATION";

}
