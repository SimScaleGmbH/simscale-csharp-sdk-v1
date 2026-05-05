using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SymmetryPSBC : OneOf_CustomFluidBCPassiveScalars
{
    /// <summary>Schema name: SymmetryPSBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SYMMETRY";

}
