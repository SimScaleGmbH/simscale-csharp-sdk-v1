using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SymmetryTDCBC : OneOf_CustomFluidBCTurbulentThermalDiffusivityCompressible
{
    /// <summary>Schema name: SymmetryTDCBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SYMMETRY";

}
