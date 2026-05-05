using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class InletOutletEBC : OneOf_CustomFluidBCEpsilonDissipationRate
{
    /// <summary>Schema name: InletOutletEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INLET_OUTLET";

    [JsonPropertyName("value")]
    public Dimensional_TurbulentDissipation? Value { get; set; }

}
