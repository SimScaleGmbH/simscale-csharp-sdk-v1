using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FalseSemiImplicit : OneOf_MULESSolverSemiImplicit
{
    /// <summary>Schema name: FalseSemiImplicit</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FALSE_SEMI_IMPLICIT";

}
