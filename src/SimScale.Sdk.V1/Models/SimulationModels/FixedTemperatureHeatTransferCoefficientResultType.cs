using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedTemperatureHeatTransferCoefficientResultType : OneOf_FieldCalculationsWallHeatFluxResultControlReferenceTemperatureResultType
{
    /// <summary>Schema name: FixedTemperatureHeatTransferCoefficientResultType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REFERENCE_TEMPERATURE_HEAT_TRANSFER_COEFFICIENT";

    [JsonPropertyName("referenceHeatTransferTemperature")]
    public Dimensional_Temperature? ReferenceHeatTransferTemperature { get; set; }

}
