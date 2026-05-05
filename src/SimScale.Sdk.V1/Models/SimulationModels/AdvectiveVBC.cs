using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdvectiveVBC : OneOf_CustomFluidBCVelocity
{
    /// <summary>Schema name: AdvectiveVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ADVECTIVE";

    [JsonPropertyName("relaxBoundary")]
    public bool? RelaxBoundary { get; set; }

    [JsonPropertyName("farFieldValue")]
    public DimensionalVector_Speed? FarFieldValue { get; set; }

    [JsonPropertyName("relaxationLengthScale")]
    public Dimensional_Length? RelaxationLengthScale { get; set; }

}
