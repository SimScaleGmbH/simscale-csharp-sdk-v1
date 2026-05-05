using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TorsionalAxialRotation : OneOf_PinKinematicBehaviorRotation
{
    /// <summary>Schema name: TorsionalAxialRotation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TORSIONAL";

    [JsonPropertyName("torsionalStiffness")]
    public Dimensional_RotationalStiffness? TorsionalStiffness { get; set; }

}
