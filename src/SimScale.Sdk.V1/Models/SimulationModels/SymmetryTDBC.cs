using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SymmetryTDBC : OneOf_CustomFluidBCTurbulentThermalDiffusivity
{
    /// <summary>Schema name: SymmetryTDBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SYMMETRY";

}
