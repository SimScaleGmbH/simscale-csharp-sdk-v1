using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CoulombFriction : OneOf_ConnectionSettingsV36Friction
{
    /// <summary>Schema name: CoulombFriction</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "COULOMB_FRICTION";

    [JsonPropertyName("nonlinearityResolution")]
    public OneOf_CoulombFrictionNonlinearityResolution? NonlinearityResolution { get; set; }

}
