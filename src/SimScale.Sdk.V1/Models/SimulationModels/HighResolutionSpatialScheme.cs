using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HighResolutionSpatialScheme : OneOf_SpatialDiscretizationSchemesVolumeOfFluid
{
    /// <summary>Schema name: HighResolutionSpatialScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HIGH_RESOLUTION";

}
