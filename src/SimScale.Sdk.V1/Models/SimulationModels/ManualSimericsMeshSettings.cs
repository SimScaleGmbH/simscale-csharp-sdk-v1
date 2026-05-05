using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ManualSimericsMeshSettings : OneOf_SimericsAnalysisMeshSettings
{
    /// <summary>Schema name: ManualSimericsMeshSettings</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL_SETTINGS";

    [JsonPropertyName("refinements")]
    public List<OneOf_ManualSimericsMeshSettingsRefinements>? Refinements { get; set; }

    [JsonPropertyName("cellSizeSpecification")]
    public OneOf_ManualSimericsMeshSettingsCellSizeSpecification? CellSizeSpecification { get; set; }

    /// <summary>Merge CAD surfaces combines all surfaces of the CAD model that are not assigned a boundary condition or result contro...</summary>
    [JsonPropertyName("enableCADSurfaceMerging")]
    public bool? EnableCADSurfaceMerging { get; set; }

}
