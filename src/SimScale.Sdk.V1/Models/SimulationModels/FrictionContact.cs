using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FrictionContact : OneOf_PhysicalContactConnections
{
    /// <summary>Schema name: FrictionContact</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FRICTION_CONTACT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("contactSolutionMethod")]
    public OneOf_FrictionContactContactSolutionMethod? ContactSolutionMethod { get; set; }

    [JsonPropertyName("frictionCoefficient")]
    public OneOf_FrictionContactFrictionCoefficient? FrictionCoefficient { get; set; }

    [JsonPropertyName("fictitiousClearance")]
    public OneOf_FrictionContactFictitiousClearance? FictitiousClearance { get; set; }

    [JsonPropertyName("masterTopologicalReference")]
    public TopologicalReference? MasterTopologicalReference { get; set; }

    [JsonPropertyName("slaveTopologicalReference")]
    public TopologicalReference? SlaveTopologicalReference { get; set; }

}
