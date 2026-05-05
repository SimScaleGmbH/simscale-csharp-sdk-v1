using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalMass : OneOf_DistributedMassBCMassDefinition
{
    /// <summary>Schema name: TotalMass</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_MASS";

    [JsonPropertyName("mass")]
    public Dimensional_Mass? Mass { get; set; }

}
