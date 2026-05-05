using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MeanValueOutletVBC : OneOf_VelocityOutletBCVelocity
{
    /// <summary>Schema name: MeanValueOutletVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MEAN_VALUE_OUTLET_VELOCITY";

    [JsonPropertyName("normalVelocity")]
    public DimensionalFunction_Speed? NormalVelocity { get; set; }

}
