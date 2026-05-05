using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FreestreamPBC : OneOf_CustomFluidBCPressure, OneOf_CustomFluidBCPressureRgh, OneOf_CustomFluidBCGaugePressure, OneOf_CustomFluidBCGaugePressureRgh
{
    /// <summary>Schema name: FreestreamPBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FREESTREAM";

}
