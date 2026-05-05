using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MixingLengthInletEBC : OneOf_CustomFluidBCEpsilonDissipationRate
{
    /// <summary>Schema name: MixingLengthInletEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TURBULENCE_MIXING_LENGTH_DISSIPATION_RATE_INLET";

    [JsonPropertyName("mixingLength")]
    public Dimensional_Length? MixingLength { get; set; }

}
