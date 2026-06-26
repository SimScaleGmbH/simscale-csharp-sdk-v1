using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AutomaticSweepOff : OneOf_SimmetrixMeshingFluidAutomaticSweepParameters, OneOf_SimmetrixMeshingSolidAutomaticSweepParameters
{
    /// <summary>Schema name: AutomaticSweepOff</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_SWEEP_MESHING_OFF";

}
