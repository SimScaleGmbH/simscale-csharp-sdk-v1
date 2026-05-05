using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WallNextCellHeatTransferCoefficientResultType : OneOf_FieldCalculationsWallHeatFluxResultControlReferenceTemperatureResultType
{
    /// <summary>Schema name: WallNextCellHeatTransferCoefficientResultType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WALL_NEXT_CELL_HEAT_TRANSFER_COEFFICIENT";

}
