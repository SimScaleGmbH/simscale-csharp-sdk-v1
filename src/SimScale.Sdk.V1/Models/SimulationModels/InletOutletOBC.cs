using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class InletOutletOBC : OneOf_CustomFluidBCOmegaDissipationRate
{
    /// <summary>Schema name: InletOutletOBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INLET_OUTLET";

    [JsonPropertyName("value")]
    public Dimensional_SpecificTurbulenceDissipationRate? Value { get; set; }

}
