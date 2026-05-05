using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RelativeToAllCadSurfacesSettings : OneOf_ManualSimericsMeshSettingsCellSizeSpecification
{
    /// <summary>Schema name: RelativeToAllCadSurfacesSettings</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE_TO_ALL_CAD_SURFACES";

    /// <summary>This parameter specifies the minimum size for all cells of the mesh relative to the diagonal of the CAD model. A high...</summary>
    [JsonPropertyName("minimumCellSize")]
    public double? MinimumCellSize { get; set; }

    /// <summary>This parameter specifies the maximum size for all cells of the mesh relative to the diagonal of the CAD model. A lowe...</summary>
    [JsonPropertyName("maximumCellSize")]
    public double? MaximumCellSize { get; set; }

    /// <summary>This parameter specifies the size of cells close to the surfaces relative to the diagonal of the CAD model. A higher...</summary>
    [JsonPropertyName("cellSizeOnSurfaces")]
    public double? CellSizeOnSurfaces { get; set; }

}
