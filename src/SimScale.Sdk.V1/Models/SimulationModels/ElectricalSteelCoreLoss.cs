using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectricalSteelCoreLoss : OneOf_ElectromagneticMaterialCoreLossesType
{
    /// <summary>Schema name: ElectricalSteelCoreLoss</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ELECTRICAL_STEEL";

    [JsonPropertyName("hysteresisLoss")]
    public double? HysteresisLoss { get; set; }

    [JsonPropertyName("eddyLoss")]
    public double? EddyLoss { get; set; }

    [JsonPropertyName("excessLoss")]
    public double? ExcessLoss { get; set; }

}
