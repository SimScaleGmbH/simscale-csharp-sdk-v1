using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NoFictitiousClearance : OneOf_FrictionContactFictitiousClearance, OneOf_FrictionlessContactFictitiousClearance
{
    /// <summary>Schema name: NoFictitiousClearance</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NO_FICTITIOUS_CLEARANCE";

}
