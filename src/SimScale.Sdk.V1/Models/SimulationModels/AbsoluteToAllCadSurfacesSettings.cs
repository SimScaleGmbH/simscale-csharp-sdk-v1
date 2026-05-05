using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AbsoluteToAllCadSurfacesSettings : OneOf_ManualSimericsMeshSettingsCellSizeSpecification
{
    /// <summary>Schema name: AbsoluteToAllCadSurfacesSettings</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ABSOLUTE_TO_ALL_CAD_SURFACES";

    [JsonPropertyName("minimumCellSize")]
    public Dimensional_Length? MinimumCellSize { get; set; }

    [JsonPropertyName("maximumCellSize")]
    public Dimensional_Length? MaximumCellSize { get; set; }

    [JsonPropertyName("cellSizeOnSurfaces")]
    public Dimensional_Length? CellSizeOnSurfaces { get; set; }

    /// <summary>Specify growth rate: Define the cell size growth rate between interior cells and surface cells.</summary>
    [JsonPropertyName("enableGrowthRate")]
    public bool? EnableGrowthRate { get; set; }

    /// <summary>The Growth rate defines the cell size ratio between interior cell size and surface cell size. It needs to be a whole...</summary>
    [JsonPropertyName("growthRate")]
    public int? GrowthRate { get; set; }

}
