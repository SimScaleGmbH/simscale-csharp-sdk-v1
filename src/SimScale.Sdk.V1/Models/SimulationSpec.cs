using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models.ParametricModels;
using SimScale.Sdk.V1.Models.SimulationModels;

namespace SimScale.Sdk.V1.Models;

public class SimulationSpec
{
    [JsonPropertyName("simulationId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid SimulationId { get; set; }

    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    /// <summary>The schema version of the simulation spec. This can be either the external version like `30.0`, or the internal versi...</summary>
    [JsonPropertyName("version")]
    public string Version { get; set; } = "34.0";

    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("modifiedAt")]
    public DateTimeOffset? ModifiedAt { get; set; }

    /// <summary>The ID of CAD input to the simulation.</summary>
    [JsonPropertyName("cadId")]
    [JsonRequired]
    public required Guid CadId { get; set; }

    /// <summary>The ID of CAD state input to the simulation.</summary>
    [JsonPropertyName("stateId")]
    [JsonRequired]
    public required Guid StateId { get; set; }

    /// <summary>The generated mesh ID which is to be used in the simulation. This field should be left empty for analysis types that...</summary>
    [JsonPropertyName("meshId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid MeshId { get; set; }

    [JsonPropertyName("model")]
    [JsonRequired]
    public required Analysis Model { get; set; }

    [JsonPropertyName("parameters")]
    public Parameters? Parameters { get; set; }

}
