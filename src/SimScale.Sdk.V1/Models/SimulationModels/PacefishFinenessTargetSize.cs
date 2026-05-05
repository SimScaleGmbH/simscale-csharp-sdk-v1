using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This parameter determines the fineness of the mesh and affects the overall number of cells. It is recommended to start with the coarse setting. Find out more.Note: This setting will impact the accuracy of your results as well as computing time and result size. A finer mesh will be more demanding in terms of machine size and memory but lead to more accurate results in most cases.</summary>
public class PacefishFinenessTargetSize : OneOf_PacefishAutomeshNewFineness, OneOf_RegionRefinementWindComfortNewFineness, OneOf_SurfaceRefinementWindComfortNewFineness, OneOf_WindComfortMeshWindComfortFineness
{
    /// <summary>This parameter determines the fineness of the mesh and affects the overall number of cells. It is recommended to star...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TARGET_SIZE";

    [JsonPropertyName("minimumCellSize")]
    public Dimensional_Length? MinimumCellSize { get; set; }

}
