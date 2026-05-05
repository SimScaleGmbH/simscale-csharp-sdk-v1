using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RotatingSBM : OneOf_AdvancedConceptsSolidBodyMotions
{
    /// <summary>Schema name: RotatingSBM</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ROTATING_MOTION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("rotation")]
    public OneOf_RotatingSBMRotation? Rotation { get; set; }

}
