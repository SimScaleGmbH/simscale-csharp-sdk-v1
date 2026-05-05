using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Computes the heat flux [W/m²] at every wall based on the surface normal gradient of the temperature. Radiation effects are not included.</summary>
public class FieldCalculationsWallHeatFluxResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Computes the heat flux [W/m²] at every wall based on the surface normal gradient of the temperature. Radiation effect...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WALL_HEAT_FLUX";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public WallHeatFluxResultType? ResultType { get; set; }

    /// <summary>Computes the heat transfer coefficient [W/(m²K)] at every wall. Radiation effects are not included. Two modes are ava...</summary>
    [JsonPropertyName("computeHeatTransferCoefficient")]
    public bool? ComputeHeatTransferCoefficient { get; set; }

    [JsonPropertyName("referenceTemperatureResultType")]
    public OneOf_FieldCalculationsWallHeatFluxResultControlReferenceTemperatureResultType? ReferenceTemperatureResultType { get; set; }

    /// <summary>Computes the Nusselt Number at every wall. The specified heat transfer coefficient mode will be used.</summary>
    [JsonPropertyName("computeNusseltNumber")]
    public bool? ComputeNusseltNumber { get; set; }

    [JsonPropertyName("referenceNusseltNumberLength")]
    public Dimensional_Length? ReferenceNusseltNumberLength { get; set; }

}
