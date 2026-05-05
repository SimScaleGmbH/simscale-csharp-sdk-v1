using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OutletMeanPhaseVBC : OneOf_CustomFluidBCVelocity, OneOf_VelocityOutletBCVelocity
{
    /// <summary>Schema name: OutletMeanPhaseVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OUTLET_MEAN_PHASE";

    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    [JsonPropertyName("meanVelocity")]
    public Dimensional_Speed? MeanVelocity { get; set; }

}
