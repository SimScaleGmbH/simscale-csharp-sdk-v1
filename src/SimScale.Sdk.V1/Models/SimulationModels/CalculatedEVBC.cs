using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CalculatedEVBC : OneOf_CustomFluidBCEddyViscosity
{
    /// <summary>Schema name: CalculatedEVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CALCULATED";

}
