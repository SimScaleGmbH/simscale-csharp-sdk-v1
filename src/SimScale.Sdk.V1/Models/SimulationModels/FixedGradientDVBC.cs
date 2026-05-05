using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedGradientDVBC : OneOf_CustomFluidBCTurbulentDynamicViscosity
{
    /// <summary>Schema name: FixedGradientDVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_GRADIENT";

    [JsonPropertyName("gradient")]
    public Dimensional_EddyViscosityGradient? Gradient { get; set; }

}
