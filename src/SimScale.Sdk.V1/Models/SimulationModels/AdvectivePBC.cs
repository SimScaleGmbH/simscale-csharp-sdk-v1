using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdvectivePBC : OneOf_CustomFluidBCPressure
{
    /// <summary>Schema name: AdvectivePBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ADVECTIVE";

    [JsonPropertyName("relaxBoundary")]
    public bool? RelaxBoundary { get; set; }

    [JsonPropertyName("farFieldValue")]
    public Dimensional_Pressure? FarFieldValue { get; set; }

    [JsonPropertyName("relaxationLengthScale")]
    public Dimensional_Length? RelaxationLengthScale { get; set; }

}
