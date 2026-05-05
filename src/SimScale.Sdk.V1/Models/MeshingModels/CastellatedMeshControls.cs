using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class CastellatedMeshControls
{
    /// <summary>Define the maximal number of cells per processor during refinement</summary>
    [JsonPropertyName("maxLocalCells")]
    public int? MaxLocalCells { get; set; }

    /// <summary>Define the maximum possible number of cells summed upon all processors. Note that this is before the castellation ste...</summary>
    [JsonPropertyName("maxGlobalCells")]
    public int? MaxGlobalCells { get; set; }

    /// <summary>If in a refinement iteration the number of cells selected for refinement is under this value, the refinement stops. P...</summary>
    [JsonPropertyName("minRefinementCells")]
    public int? MinRefinementCells { get; set; }

    /// <summary>Define a fraction indicating the maximum allowable load imbalance between processors working on this job. A value of...</summary>
    [JsonPropertyName("maxLoadUnbalance")]
    public double? MaxLoadUnbalance { get; set; }

    /// <summary>This parameter specifies the number of layers of cells between different levels of refinement (see documentation).</summary>
    [JsonPropertyName("cellsBetweenLevels")]
    public int? CellsBetweenLevels { get; set; }

    /// <summary>Cells that face multiple intersections with an intersection angle greater than this angle will be refined to the max...</summary>
    [JsonPropertyName("resolveFeatureAngle")]
    public double? ResolveFeatureAngle { get; set; }

    /// <summary>Decide whether you want to allow zone faces that share the same owner and neighbour cell zone. Allowing this can lead...</summary>
    [JsonPropertyName("allowFreeStandingZoneFaces")]
    public bool? AllowFreeStandingZoneFaces { get; set; }

}
