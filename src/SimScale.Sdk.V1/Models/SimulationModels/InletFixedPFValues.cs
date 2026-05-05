using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class InletFixedPFValues
{
    /// <summary>Schema name: InletFixedPFValues</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INLET_FIXED_PF_VALUES";

    [JsonPropertyName("phaseFractions")]
    public List<FixedValuePhaseFractionBC>? PhaseFractions { get; set; }

}
