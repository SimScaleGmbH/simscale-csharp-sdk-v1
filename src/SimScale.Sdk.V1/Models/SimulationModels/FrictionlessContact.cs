using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FrictionlessContact : OneOf_PhysicalContactConnections
{
    /// <summary>Schema name: FrictionlessContact</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FRICTIONLESS_CONTACT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("contactSolutionMethod")]
    public OneOf_FrictionlessContactContactSolutionMethod? ContactSolutionMethod { get; set; }

    [JsonPropertyName("fictitiousClearance")]
    public OneOf_FrictionlessContactFictitiousClearance? FictitiousClearance { get; set; }

    [JsonPropertyName("masterTopologicalReference")]
    public TopologicalReference? MasterTopologicalReference { get; set; }

    [JsonPropertyName("slaveTopologicalReference")]
    public TopologicalReference? SlaveTopologicalReference { get; set; }

}
