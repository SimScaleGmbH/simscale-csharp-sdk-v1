using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PenaltyMethod : OneOf_FrictionContactContactSolutionMethod, OneOf_FrictionlessContactContactSolutionMethod
{
    /// <summary>Schema name: PenaltyMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PENALTY_METHOD";

    [JsonPropertyName("contactStiffness")]
    public OneOf_PenaltyMethodContactStiffness? ContactStiffness { get; set; }

}
