using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsSurfaceNormalsResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsSurfaceNormalsResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SURFACE_NORMALS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public SurfaceNormalsResultType? ResultType { get; set; }

}
