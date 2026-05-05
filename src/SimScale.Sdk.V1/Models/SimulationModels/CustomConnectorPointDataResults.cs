using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomConnectorPointDataResults : OneOf_MarcConnectorPointDataItemResults
{
    /// <summary>Schema name: CustomConnectorPointDataResults</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM";

    [JsonPropertyName("displacements")]
    public bool? Displacements { get; set; }

    [JsonPropertyName("rotations")]
    public bool? Rotations { get; set; }

    [JsonPropertyName("reactionForces")]
    public bool? ReactionForces { get; set; }

    [JsonPropertyName("reactionMoments")]
    public bool? ReactionMoments { get; set; }

    [JsonPropertyName("externalForces")]
    public bool? ExternalForces { get; set; }

    [JsonPropertyName("externalMoments")]
    public bool? ExternalMoments { get; set; }

}
