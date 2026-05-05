using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ResidualControls
{
    [JsonPropertyName("velocity")]
    public Tolerance? Velocity { get; set; }

    [JsonPropertyName("pressure")]
    public Tolerance? Pressure { get; set; }

    [JsonPropertyName("pressureRgh")]
    public Tolerance? PressureRgh { get; set; }

    [JsonPropertyName("temperature")]
    public Tolerance? Temperature { get; set; }

    [JsonPropertyName("turbulentKineticEnergy")]
    public Tolerance? TurbulentKineticEnergy { get; set; }

    [JsonPropertyName("omegaDissipationRate")]
    public Tolerance? OmegaDissipationRate { get; set; }

    [JsonPropertyName("epsilonDissipationRate")]
    public Tolerance? EpsilonDissipationRate { get; set; }

}
