using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalCartesianMagnetizationDirectionMethod : OneOf_PermanentMagnetMaterialMagnetizationDirectionType
{
    /// <summary>Schema name: GlobalCartesianMagnetizationDirectionMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GLOBAL_CARTESIAN";

    [JsonPropertyName("magnetizationDirection")]
    public DimensionalVector_Dimensionless? MagnetizationDirection { get; set; }

}
