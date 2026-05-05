using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AreaDensityMass : OneOf_DistributedMassBCMassDefinition
{
    /// <summary>Schema name: AreaDensityMass</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AREA_DENSITY_MASS";

    [JsonPropertyName("mass")]
    public Dimensional_MassAreaDensity? Mass { get; set; }

}
