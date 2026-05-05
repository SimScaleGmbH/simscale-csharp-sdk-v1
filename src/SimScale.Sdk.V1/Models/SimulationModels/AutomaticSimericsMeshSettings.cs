using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticSimericsMeshSettings : OneOf_SimericsAnalysisMeshSettings
{
    /// <summary>Schema name: AutomaticSimericsMeshSettings</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_SETTINGS";

    [JsonPropertyName("refinements")]
    public List<OneOf_AutomaticSimericsMeshSettingsRefinements>? Refinements { get; set; }

    /// <summary>Adjust the overall mesh sizing from coarse (value: 0) to fine (10).</summary>
    [JsonPropertyName("fineness")]
    public double? Fineness { get; set; }

    /// <summary>Merge CAD surfaces combines all surfaces of the CAD model that are not assigned a boundary condition or result contro...</summary>
    [JsonPropertyName("enableCADSurfaceMerging")]
    public bool? EnableCADSurfaceMerging { get; set; }

}
