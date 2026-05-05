using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WallHeatTransferTBC : OneOf_CustomFluidBCTemperature
{
    /// <summary>Schema name: WallHeatTransferTBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WALL_HEAT_TRANSFER";

    [JsonPropertyName("wallTemperature")]
    public Dimensional_Temperature? WallTemperature { get; set; }

    [JsonPropertyName("thermalDiffusivity")]
    public Dimensional_KinematicViscosity? ThermalDiffusivity { get; set; }

}
