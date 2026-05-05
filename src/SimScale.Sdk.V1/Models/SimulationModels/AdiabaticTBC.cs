using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdiabaticTBC : OneOf_CustomFluidBCTemperature, OneOf_WallBCTemperature
{
    /// <summary>Schema name: AdiabaticTBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ADIABATIC";

}
