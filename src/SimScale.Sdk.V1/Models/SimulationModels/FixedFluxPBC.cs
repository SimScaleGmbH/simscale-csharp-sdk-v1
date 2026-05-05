using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedFluxPBC : OneOf_CustomFluidBCPressureRgh, OneOf_CustomFluidBCGaugePressureRgh
{
    /// <summary>Schema name: FixedFluxPBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_FLUX_PRESSURE";

}
