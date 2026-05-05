using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class InletFixedMFValues
{
    /// <summary>Schema name: InletFixedMFValues</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INLET_FIXED_MF_VALUES";

    [JsonPropertyName("massFractions")]
    public List<FixedValueMassFractionBC>? MassFractions { get; set; }

}
