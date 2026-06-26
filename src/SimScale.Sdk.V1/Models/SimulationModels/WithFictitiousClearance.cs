using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WithFictitiousClearance : OneOf_FrictionContactFictitiousClearance, OneOf_FrictionlessContactFictitiousClearance
{
    /// <summary>Schema name: WithFictitiousClearance</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WITH_FICTITIOUS_CLEARANCE";

    [JsonPropertyName("masterClearance")]
    public DimensionalFunction_Length? MasterClearance { get; set; }

    [JsonPropertyName("slaveClearance")]
    public DimensionalFunction_Length? SlaveClearance { get; set; }

}
