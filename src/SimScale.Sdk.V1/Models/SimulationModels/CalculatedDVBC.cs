using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CalculatedDVBC : OneOf_CustomFluidBCTurbulentDynamicViscosity
{
    /// <summary>Schema name: CalculatedDVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CALCULATED";

}
